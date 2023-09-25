using Classes;
using DAL;
using DesktopApp.Edit_Forms;
using DesktopApp.Info_Forms;
using LL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;

namespace DesktopApp
{
    public partial class Calendar : Form
    {

        IDepartmentManager departmentManager = new DepartmentManager(new DepartmentDAO());
        IUserManager userManager = new UserManager(new UserDAO());
        ShiftManager shiftManager = new ShiftManager(new ShiftDAO());
        public int globalOffset = 0;
        public DateOnly startofweek;
        public DateOnly shiftDate;
        public int shiftType;
        public int refe = 1;
        public Calendar()
        {
            InitializeComponent();
            LoadCombo();
            cbDepartments.SelectedIndexChanged += cbDepartments_SelectedIndexChanged;
            DataMonday.AutoSize = true;
            DataTuesday.AutoSize = true;
            DataWednesday.AutoSize = true;
            DataThursday.AutoSize = true;
            DataFriday.AutoSize = true;
            DataSaturday.AutoSize = true;
            DataSunday.AutoSize = true;
            pictureLoading.Visible = false;
        }


        private void LoadCombo()
        {
            cbDepartments.DataSource = null;
            cbDepartments.DataSource = departmentManager.GetAllDepartments();
            if (cbDepartments.SelectedValue != null)
            {
                btnnext.Tag = 0;
                DisplayShiftWindows((int)btnnext.Tag);
            }


        }

        private void cbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            shiftweekpanel.Controls.Clear();
            DisplayShiftWindows(globalOffset);
        }


        public void DisplayShiftWindows(int offset)
        {
            DateTime now = DateTime.Now;
            offset = (int)btnnext.Tag;
            DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);

            int weekday_month_start = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            int diff = (7 + Convert.ToInt32(now.DayOfWeek - DayOfWeek.Monday)) % 7;

            DateTime startofweek = now.AddDays(-1 * diff + (7 - weekday_month_start) + offset + 1).Date;
            var mondayOfTheWeek = now.AddDays(offset + -1 * diff);

            tbweek.Text = "Week " + mondayOfTheWeek.Day + "/" + mondayOfTheWeek.Month + " - " + (mondayOfTheWeek.AddDays(7).Day) + "/" + mondayOfTheWeek.AddDays(7).Month;

            DateOnly currentDate = DateOnly.FromDateTime(mondayOfTheWeek);
            DateOnly today = DateOnly.FromDateTime(DateTime.Today);

            DataMonday.Text = currentDate.ToString();
            DataMonday.BackColor = (currentDate == today) ? ColorTranslator.FromHtml("#BDD7EE") : SystemColors.Control;

            DataTuesday.Text = currentDate.AddDays(1).ToString();
            DataTuesday.BackColor = (currentDate.AddDays(1) == today) ? ColorTranslator.FromHtml("#BDD7EE") : SystemColors.Control;

            DataWednesday.Text = currentDate.AddDays(2).ToString();
            DataWednesday.BackColor = (currentDate.AddDays(2) == today) ? ColorTranslator.FromHtml("#BDD7EE") : SystemColors.Control;

            DataThursday.Text = currentDate.AddDays(3).ToString();
            DataThursday.BackColor = (currentDate.AddDays(3) == today) ? ColorTranslator.FromHtml("#BDD7EE") : SystemColors.Control;

            DataFriday.Text = currentDate.AddDays(4).ToString();
            DataFriday.BackColor = (currentDate.AddDays(4) == today) ? ColorTranslator.FromHtml("#BDD7EE") : SystemColors.Control;

            DataSaturday.Text = currentDate.AddDays(5).ToString();
            DataSaturday.BackColor = (currentDate.AddDays(5) == today) ? ColorTranslator.FromHtml("#BDD7EE") : SystemColors.Control;

            DataSunday.Text = currentDate.AddDays(6).ToString();
            DataSunday.BackColor = (currentDate.AddDays(6) == today) ? ColorTranslator.FromHtml("#BDD7EE") : SystemColors.Control;

            lblmonday.BackColor = (currentDate == today) ? ColorTranslator.FromHtml("#BDD7EE") : SystemColors.Control;
            lbltuesday.BackColor = (currentDate.AddDays(1) == today) ? ColorTranslator.FromHtml("#BDD7EE") : SystemColors.Control;
            lblwed.BackColor = (currentDate.AddDays(2) == today) ? ColorTranslator.FromHtml("#BDD7EE") : SystemColors.Control;
            lblthu.BackColor = (currentDate.AddDays(3) == today) ? ColorTranslator.FromHtml("#BDD7EE") : SystemColors.Control;
            lblfri.BackColor = (currentDate.AddDays(4) == today) ? ColorTranslator.FromHtml("#BDD7EE") : SystemColors.Control;
            lblsat.BackColor = (currentDate.AddDays(5) == today) ? ColorTranslator.FromHtml("#BDD7EE") : SystemColors.Control;
            lblsun.BackColor = (currentDate.AddDays(6) == today) ? ColorTranslator.FromHtml("#BDD7EE") : SystemColors.Control;


            for (int i = 0; i < 21; i++)
            {
                //generate shiftid as the UC tag
                DateTime currentSelectedDay = mondayOfTheWeek.AddDays(i / 3);
                if (i % 3 != 0) currentSelectedDay.AddDays(1);

                shiftType = (i % 3);
                shiftDate = DateOnly.FromDateTime(currentSelectedDay);
                CalendarInfo ucblank = new CalendarInfo(shiftDate, shiftType, Convert.ToString(cbDepartments.SelectedValue), this);
                ucblank.Tag = shiftDate.ToString("dd/MM/yy") + shiftType.ToString();

                shiftweekpanel.Controls.Add(ucblank);


            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnrefresh_Click(object sender, EventArgs e)
        {

            shiftweekpanel.Controls.Clear();
            DisplayShiftWindows(globalOffset);

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            //clear panel
            shiftweekpanel.Controls.Clear();
            btnnext.Tag = (int)btnnext.Tag + 7;
            globalOffset = (int)btnnext.Tag;
            DisplayShiftWindows(globalOffset);
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            //clear panel
            shiftweekpanel.Controls.Clear();
            btnnext.Tag = (int)btnnext.Tag - 7;
            globalOffset = (int)btnnext.Tag;
            DisplayShiftWindows(globalOffset);
        }

        private void btnCurrentWeek_Click(object sender, EventArgs e)
        {
            shiftweekpanel.Controls.Clear();
            btnnext.Tag = 0;
            globalOffset = (int)btnnext.Tag;
            DisplayShiftWindows(globalOffset);
        }

        private void GenerateScheduleButton_Click(object sender, EventArgs e)
        {
            shiftweekpanel.Visible = false;
            SetPictureLoadingVisibility(true);
            Generete2(sender, e);
        }

        private async Task Generete2(object sender, EventArgs e)
        {
            Department department = cbDepartments.SelectedItem as Department;
            string UserNames = string.Empty;
            await Task.Run(() =>
            {
                List<(Classes.User user, DateTime date, int type)> RejectedEmployee = new();
                DateTime now = DateTime.Now;
                DateTime startDate = now.AddDays(1);
                startDate = startDate.Add(TimeSpan.Zero);
                DateTime endDate = now.AddDays(7);
                endDate = endDate.Add(TimeSpan.Zero);
                List<Classes.User> EmployeeWithPreferedScheduleByDepartment = userManager.EmployeeWithPreferedScheduleByDepartment(department.DepartmentId);
                List<Classes.User> EmployeeWithoutPreferedScheduleByDepartment = new();
                List<Classes.User> list2 = new List<Classes.User>();
                List<ShiftType> types = new()
                {
                    ShiftType.Morning,
                    ShiftType.Afternoon,
                    ShiftType.Night
                };

                DateTime dateg = startDate;
                dateg = dateg.Add(TimeSpan.Zero);
                while (dateg <= endDate)
                {
                    foreach (ShiftType type in types)
                    {
                        if (shiftManager.GetScheduleByShiftTypeAndDate(new DateOnly(dateg.Year, dateg.Month, dateg.Day), (int)type, department.Name).Count == 0)
                        {
                            shiftManager.CreateShiftForGenerater(new DateOnly(dateg.Year, dateg.Month, dateg.Day), (int)type, 5);
                        }

                    }
                    dateg = dateg.AddDays(1);
                }
                Random random = new Random();
                for (int i = EmployeeWithPreferedScheduleByDepartment.Count - 1; i > 0; i--)
                {
                    int j = random.Next(i + 1);
                    Classes.User temp = EmployeeWithPreferedScheduleByDepartment[i];
                    EmployeeWithPreferedScheduleByDepartment[i] = EmployeeWithPreferedScheduleByDepartment[j];
                    EmployeeWithPreferedScheduleByDepartment[j] = temp;
                }

                foreach (Classes.User user in EmployeeWithPreferedScheduleByDepartment)
                {
                    List<(DateTime date, int ShiftType)> PreferedSchedule = shiftManager.GetPreferedScheduleByUserId(user.UserID, startDate, endDate);
                    if (PreferedSchedule.Count == 0)
                    {
                        EmployeeWithoutPreferedScheduleByDepartment.Add(user);
                    }
                    else
                    {
                        for (int i = PreferedSchedule.Count; i <= 6; i++)
                        {
                            PreferedSchedule.Add((PreferedSchedule[i - 1].date.AddDays(1), -1));
                        }

                        foreach (var schedule in PreferedSchedule)
                        {
                            DateTime date = schedule.date;
                            int type = schedule.ShiftType;
                            if (shiftManager.CheckEmployeeOnDate(new DateOnly(date.Year, date.Month, date.Day), user.UserID) == false && type != -1)
                            {
                                if (shiftManager.GetScheduleByShiftTypeAndDate(new DateOnly(date.Year, date.Month, date.Day), type, department.Name).Count != 0)
                                {
                                    Shift shift = shiftManager.GetScheduleByShiftTypeAndDate(new DateOnly(date.Year, date.Month, date.Day), type, department.Name)[0];
                                    shiftManager.AddEmployeeToShift(shift.ShiftID, user.UserID);
                                }
                                else
                                {
                                    List<int> employees = new()
                            {
                                user.UserID
                            };
                                    bool result = shiftManager.UpdateShift(new DateOnly(date.Year, date.Month, date.Day), type, employees, 5);
                                }
                            }
                            else if (shiftManager.CheckEmployeeOnDate(new DateOnly(date.Year, date.Month, date.Day), user.UserID) == true)
                            {
                                RejectedEmployee.Add((user, date, type));
                            }
                            else
                            {
                                if (type == -1) RejectedEmployee.Add((user, date, type));
                            }
                        }
                        //for(DateTime i=startDate;i<=endDate;i=i.AddDays(1))
                        //{
                        //    int ok = 0;
                        //    foreach (var schedule in PreferedSchedule)
                        //    {
                        //        if (i == schedule.date) ok = 1;
                        //    }
                        //    if(ok==0)
                        //    {
                        //        RejectedEmployee.Add((user, i, ShiftType.Morning));
                        //        RejectedEmployee.Add((user, i, ShiftType.Afternoon));
                        //        RejectedEmployee.Add((user, i, ShiftType.Night));
                        //    }
                        //}
                    }


                }
                foreach (Classes.User user1 in userManager.GetUsersByDepartment(department))
                {
                    int ok = 1;
                    foreach (Classes.User user2 in EmployeeWithPreferedScheduleByDepartment)
                    {
                        if (user1.UserID == user2.UserID)
                        {
                            ok = 0;
                        }
                    }
                    if (ok == 1 && user1.UserType == UserType.Employee) EmployeeWithoutPreferedScheduleByDepartment.Add(user1);
                }
                foreach (var reject in RejectedEmployee)
                {
                    List<int> shifts_type = new()
                {
                   (int) ShiftType.Morning,
                    (int)ShiftType.Afternoon,
                    (int)ShiftType.Night
                };
                    shifts_type.Remove(reject.type);
                    bool result = false;
                    while (result == false)
                    {
                        if (shifts_type.Count == 0) break;
                        int newtype = shifts_type[random.Next(shifts_type.Count)];
                        if (shiftManager.CheckEmployeeAllowedToday(new DateOnly(reject.date.Year, reject.date.Month, reject.date.Day), (int)newtype, reject.user.UserID))
                        {
                            if (shiftManager.GetScheduleByShiftTypeAndDate(new DateOnly(reject.date.Year, reject.date.Month, reject.date.Day), (int)newtype, department.Name).Count != 0)
                            {
                                Shift shift = shiftManager.GetScheduleByShiftTypeAndDate(new DateOnly(reject.date.Year, reject.date.Month, reject.date.Day), (int)newtype, department.Name)[0];
                                shiftManager.AddEmployeeToShift(shift.ShiftID, reject.user.UserID);
                                result = true;

                            }
                            else
                            {
                                List<int> employees = new()
                            {
                                reject.user.UserID
                            };
                                shiftManager.UpdateShift(new DateOnly(reject.date.Year, reject.date.Month, reject.date.Day), (int)newtype, employees, 5);
                                result = true;

                            }
                        }
                        else
                        {
                            int ok = 0;
                            foreach (Classes.User user in list2)
                            {
                                if (user.UserID == reject.user.UserID)
                                {
                                    ok = 1;
                                }
                            }
                            if (ok == 0) list2.Add(reject.user);
                        }
                        shifts_type.Remove(newtype);
                    }
                }

                for (int i = EmployeeWithoutPreferedScheduleByDepartment.Count - 1; i > 0; i--)
                {
                    int j = random.Next(i + 1);
                    Classes.User temp = EmployeeWithoutPreferedScheduleByDepartment[i];
                    EmployeeWithoutPreferedScheduleByDepartment[i] = EmployeeWithoutPreferedScheduleByDepartment[j];
                    EmployeeWithoutPreferedScheduleByDepartment[j] = temp;
                }
                foreach (Classes.User user in EmployeeWithoutPreferedScheduleByDepartment)
                {
                    List<(DateTime date, ShiftType ShiftType)> FreeSpots = shiftManager.GetFreeSpotsBetweenStartAndEnd(startDate, endDate);

                    for (int index = 1; index <= 7; index++)
                    {
                        bool result = false;

                        while (result == false)
                        {
                            if (FreeSpots.Count > 0) result = false;
                            else
                            {
                                result = true;
                                break;
                            }
                            var spot = FreeSpots[random.Next(FreeSpots.Count)];
                            if (shiftManager.CheckEmployeeOnDate(new DateOnly(spot.date.Year, spot.date.Month, spot.date.Day), user.UserID) == false)
                            {

                                if (shiftManager.GetScheduleByShiftTypeAndDate(new DateOnly(spot.date.Year, spot.date.Month, spot.date.Day), (int)spot.ShiftType, department.Name).Count != 0)
                                {
                                    Shift shift = shiftManager.GetScheduleByShiftTypeAndDate(new DateOnly(spot.date.Year, spot.date.Month, spot.date.Day), (int)spot.ShiftType, department.Name)[0];
                                    shiftManager.AddEmployeeToShift(shift.ShiftID, user.UserID);
                                    result = true;
                                }
                                else
                                {
                                    List<int> employees = new()
                            {
                                user.UserID
                            };
                                    shiftManager.UpdateShift(new DateOnly(spot.date.Year, spot.date.Month, spot.date.Day), (int)spot.ShiftType, employees, 5);
                                    result = true;
                                }
                            }
                        }


                    }

                }

                List<(DateTime date, ShiftType ShiftType)> FreeeSpots = shiftManager.GetFreeSpotsBetweenStartAndEnd(startDate, endDate);
                if (list2.Count > 0)
                {
                    UserNames = "Employees without shift:";
                    foreach (Classes.User user in list2)
                    {
                        UserNames += $"{user.FirstName} {user.LastName}, ";
                    }
                    UserNames = UserNames.TrimEnd(',', ' ');



                }


            });

            SetPictureLoadingVisibility(false);
            shiftweekpanel.Visible = true;
            btnrefresh_Click(sender, e);
            if (!string.IsNullOrEmpty(UserNames))
            {
                MessageBox.Show(UserNames);
            }

        }

        private async void SetPictureLoadingVisibility(bool isVisible)
        {
            pictureLoading.Visible = isVisible;
            pictureLoading.BringToFront();

            Application.DoEvents();
        }

        private void DeleteCurrentSchedule_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime startDate = now.AddDays(1);

            startDate = startDate.Add(TimeSpan.Zero);
            DateTime endDate = now.AddDays(7);
            endDate = endDate.Add(TimeSpan.Zero);
            List<int> employees = new List<int>();
            List<ShiftType> types = new()
                {
                    ShiftType.Morning,
                    ShiftType.Afternoon,
                    ShiftType.Night
                };
            while (startDate <= endDate)
            {
                foreach (ShiftType type in types)
                    shiftManager.UpdateShift(new DateOnly(startDate.Year, startDate.Month, startDate.Day), (int)type, employees, 0);
                startDate = startDate.AddDays(1);
            }
            btnrefresh_Click(sender, e);
        }

    }
}

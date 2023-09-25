using Classes;
using DAL;
using DesktopApp.Edit_Forms;
using LL;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DesktopApp.Info_Forms
{

    public partial class CalendarInfo : UserControl
    {

        IShiftManager shiftManager = new ShiftManager(new ShiftDAO());
        IUserManager userManager = new UserManager(new UserDAO());
        public DateOnly Date;
        public int time = new int();
        public string name1;
        public int numberEmployee;
        private Calendar calendarForm;
        public CalendarInfo(DateOnly date, int type, string NameDepartment, Calendar calendar)
        {
            InitializeComponent();
            this.Date = date;
            this.time = type;
            this.name1 = NameDepartment;
            this.calendarForm = calendar;
            loadShift(Date, time);



        }

        private void loadShift(DateOnly date, int type)
        {

            toolTip1 = new System.Windows.Forms.ToolTip();
            int id;
            string name = "";
            List<Shift> shifts = shiftManager.GetScheduleByShiftTypeAndDate(date, type, name1);
            Classes.User user = new Classes.User();
            HashSet<string> uniqueNames = new HashSet<string>();

            for (int shiftIndex = 0; shiftIndex < shifts.Count; shiftIndex++)
            {
                for (int employeeIndex = 0; employeeIndex < shifts[shiftIndex].Employees.Count; employeeIndex++)
                {
                    user = userManager.GetUserByID(shifts[shiftIndex].Employees[employeeIndex].UserID);
                    string fullName = user.FirstName + " " + user.LastName;

                    if (!uniqueNames.Contains(fullName))
                    {
                        uniqueNames.Add(fullName);
                        name = name + fullName + "\n";
                        numberEmployee = shifts[shiftIndex].numEmpl;
                    }
                }
            }

            if (shifts.Count == 0)
            {
                name = "No employees!";
                toolTip1.SetToolTip(this, name);
                numberEmployee = 5;
            }

            toolTip1.SetToolTip(this, name);


            if (shifts.Count >= 0 && shifts.Count < numberEmployee)
            {
                this.BackColor = ColorTranslator.FromHtml("#FFE699");//yellow
                tbscheduledcount.Text = shifts.Count.ToString() + "/" + numberEmployee;
            }
            else if (shifts.Count == numberEmployee)
            {
                this.BackColor = ColorTranslator.FromHtml("#C6E0B4");//green
                tbscheduledcount.Text = shifts.Count.ToString() + "/" + numberEmployee;
            }
        }

        private void CalendarInfo_OnDoubleClick(object sender, EventArgs e)
        {

            EditCalendar shiftEditWindow = new EditCalendar(Date, time, name1, numberEmployee);
            shiftEditWindow.Closed += (sender, e) =>
            {
                calendarForm.btnrefresh_Click(sender, e);
            };
            shiftEditWindow.Show();


        }

    }
}

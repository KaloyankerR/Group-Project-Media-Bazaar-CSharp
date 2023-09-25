using Classes;
using DAL;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public class ShiftManager: IShiftManager
    {
        IShiftDAO shiftDAO;
        IUserDAO userDAO;
        UserManager userManager = new UserManager(new UserDAO());

        public ShiftManager(IShiftDAO shiftDAO)
        {
            this.shiftDAO = shiftDAO;
        }
        public ShiftManager (IUserDAO userDAO) 
        {
            this.userDAO = userDAO;
        }

        public bool CreateShift(DateOnly date, int type, List<int> employees, int numEmpl)
        {

            try
            {
                if (shiftDAO.CreateShift(date, type, employees, numEmpl))
                {
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateShift(DateOnly date, int type, List<int> employees, int numEmpl)
        {

            try
            {

                bool removed = shiftDAO.DeleteShift(date, type);
                bool created = shiftDAO.CreateShift(date, type, employees, numEmpl);
                if (created && removed) return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }
            
        public List<Shift> GetAllShifts()
        {

            Shift shift;
            UserManager userManager = new(new UserDAO());
            
            List<Shift> shifts = new List<Shift>();
            

            foreach (ShiftDTO shiftDTO in shiftDAO.GetAllShifts())
            {
                List<User> users = userManager.GetAllUsers();
                
                ShiftType shiftType = (ShiftType)shiftDTO.ShiftType;
                shift = new Shift(shiftDTO.ShiftID, shiftDTO.Date, shiftType, users, shiftDTO.numEmpl);
                shifts.Add(shift);
            }
            return shifts;
        }


        public bool AddEmployeeToShift(int shiftId, int employeeId)
        {
            try
            {
                if (shiftDAO.AddEmployeeToShift(shiftId,employeeId))
                {
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }

        public List<Shift> GetScheduleByShiftId(int id)
        {
            Shift shift;
            UserManager userManager = new(new UserDAO());
            List<Shift> shifts = new List<Shift>();
            foreach (ShiftDTO shiftDTO in shiftDAO.GetAllShifts())
            {
                List<User> users = userManager.GetAllUsers();

                ShiftType shiftType = (ShiftType)shiftDTO.ShiftType;
                shift = new Shift(shiftDTO.ShiftID, shiftDTO.Date, shiftType, users, shiftDTO.numEmpl);
                if(shiftDTO.ShiftID == id)
                {
                    shifts.Add(shift);
                }
                
            }
            return shifts;

        }

        public List<Shift> GetScheduleByShiftTypeAndDate(DateOnly date, int type, string department)
        {
            Shift shift;
            UserManager userManager = new(new UserDAO());

            List<Shift> shifts = new List<Shift>();


            foreach (ShiftDTO shiftDTO in shiftDAO.GetScheduleByShiftTypeAndDate(date, type, department))
            {
                List<User> users = userManager.GetUsersByShiftID(Convert.ToInt32(shiftDTO.ShiftID));
                
                ShiftType shiftType = (ShiftType)shiftDTO.ShiftType;
                shift = new Shift(shiftDTO.ShiftID, shiftDTO.Date, shiftType, users, shiftDTO.numEmpl);
                shifts.Add(shift);
            }
            return shifts;
        }

        public Shift GetShiftEmployeeId(int id)
        {
            Shift shift;
            UserManager userManager = new(new UserDAO());
            foreach (ShiftDTO shiftDTO in shiftDAO.GetAllShifts())
            {
                List<User> users = userManager.GetAllUsers();

                ShiftType shiftType = (ShiftType)shiftDTO.ShiftType;
                shift = new Shift(shiftDTO.ShiftID, shiftDTO.Date, shiftType, users, shiftDTO.numEmpl);
                if (shiftDTO.EmployeeId == id)
                {
                    return shift;
                }
                
            }
            return null;
        }

        public Shift GetShiftEmployeeByTypeId(int type)
        {
            Shift shift;
            UserManager userManager = new(new UserDAO());
            foreach (ShiftDTO shiftDTO in shiftDAO.GetAllShifts())
            {
                List<User> users = userManager.GetAllUsers();

                ShiftType shiftType = (ShiftType)shiftDTO.ShiftType;
                shift = new Shift(shiftDTO.ShiftID, shiftDTO.Date, shiftType, users, shiftDTO.numEmpl);
                if ((int)shiftDTO.ShiftType == type)
                {
                    return shift;
                }

            }
            return null;
        }

        public Shift GetShiftEmployeeByDate(DateOnly date)
        {
            Shift shift;
            UserManager userManager = new(new UserDAO());
            foreach (ShiftDTO shiftDTO in shiftDAO.GetAllShifts())
            {
                List<User> users = userManager.GetAllUsers();

                ShiftType shiftType = (ShiftType)shiftDTO.ShiftType;
                shift = new Shift(shiftDTO.ShiftID, shiftDTO.Date, shiftType, users, shiftDTO.numEmpl);
                if (shiftDTO.Date == date)
                {
                    return shift;
                }

            }
            return null;
        }
        public bool CheckEmployeeOnShift(DateOnly date, int type, int employeeid)
        {
            return shiftDAO.CheckEmployeeOnShift(date, type, employeeid);
        }

        public bool CheckEmployeeAllowedToday(DateOnly date, int type, int employeeid)
        {
            int shift1 = 0;
            int shift2 = 0;

            //generate the other 2 shifts of the day
            if (type == 0) //morning
            {
                shift1 = 1; //day
                shift2 = 2; //evening
            }
            if (type == 1)
            {
                shift1 = 0; //morning
                shift2 = 2; //evening
            }
            if (type == 2)
            {
                shift1 = 0; //morning
                shift2 = 1; //day
            }


            bool result1 = shiftDAO.CheckEmployeeOnShift(date, shift1, employeeid);
            bool result2 = shiftDAO.CheckEmployeeOnShift(date, shift2, employeeid);

            if (!result1 && !result2) return true; //allowed to work
            else return false; //already scheduled, not allowed to work

        }

        public bool SetPreferedScheduleForUser(int idUser, string day, int type, DateTime selectedDate)
        {
            return shiftDAO.SetPreferedScheduleForUser(idUser, day, type, selectedDate);
        }

        public int? GetPreferedScheduleForUser(int idUser, string day, DateTime selectedDate)
        {
            return shiftDAO.GetPreferedScheduleForUser(idUser,day, selectedDate);
        }
        public bool DeletePreferedScheduleForUser(int idUser, DateTime selectedDate)
        {
            return shiftDAO.DeletePreferedScheduleForUser(idUser, selectedDate);
        }

        public bool CheckEmployeeOnDate(DateOnly date, int employeeid)
        {
            return shiftDAO.CheckEmployeeOnDate(date, employeeid);
        }

        public List<(DateTime date, int shiftType)> GetPreferedScheduleByUserId(int id, DateTime startDate, DateTime endDate)
        {
            return shiftDAO.GetPreferedScheduleByUserId(id, startDate, endDate);
        }
        public List<(DateTime date, ShiftType shiftType)> GetFreeSpotsBetweenStartAndEnd(DateTime startDate, DateTime endDate)
        {
            return shiftDAO.GetFreeSpotsBetweenStartAndEnd(startDate, endDate);
        }
        public bool CreateShiftForGenerater(DateOnly date, int type, int numEmpl)
        {
            return shiftDAO.CreateShiftForGenerater(date, type, numEmpl);
        }
    }
}

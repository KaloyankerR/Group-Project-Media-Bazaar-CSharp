using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public interface IShiftManager
    {
        public bool CreateShift(DateOnly date, int type, List<int> employees, int numEmpl);
        public bool UpdateShift(DateOnly date, int type, List<int> employees, int numEmpl);
        public List<Shift> GetScheduleByShiftId(int id);
        public List<Shift> GetScheduleByShiftTypeAndDate(DateOnly date, int type, string department);
        public Shift GetShiftEmployeeId(int id);
        public Shift GetShiftEmployeeByTypeId(int type);
        public Shift GetShiftEmployeeByDate(DateOnly date);
        public List<Shift> GetAllShifts();
        public bool AddEmployeeToShift(int shiftId, int employeeId);
        public bool CheckEmployeeAllowedToday(DateOnly date, int type, int employeeid);
        public bool CheckEmployeeOnShift(DateOnly date, int type, int employeeid);
        public bool SetPreferedScheduleForUser(int idUser, string day, int type, DateTime selectedDate);
        public int? GetPreferedScheduleForUser(int idUser, string day, DateTime selectedDate);
        public bool DeletePreferedScheduleForUser(int idUser, DateTime selectedDate);
        public bool CheckEmployeeOnDate(DateOnly date, int employeeid);
        public List<(DateTime date, int shiftType)> GetPreferedScheduleByUserId(int id, DateTime startDate, DateTime endDate);
        public List<(DateTime date, ShiftType shiftType)> GetFreeSpotsBetweenStartAndEnd(DateTime startDate, DateTime endDate);
        public bool CreateShiftForGenerater(DateOnly date, int type, int numEmpl);

    }
}

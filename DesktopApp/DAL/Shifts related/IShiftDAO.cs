using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IShiftDAO
    {
        public bool CreateShift(DateOnly date, int type, List<int> employees, int numEmpl);
        public bool DeleteShift(DateOnly date, int type);
        public List<ShiftDTO> GetScheduleByShiftId(int id);
        public List<ShiftDTO> GetScheduleByShiftTypeAndDate(DateOnly date,int type, string department);
        public ShiftDTO GetShiftEmployeeId(int id);
        public ShiftDTO GetShiftEmployeeByTypeId(int type);
        public ShiftDTO GetShiftEmployeeByDate(DateOnly date);
        public List<ShiftDTO> GetAllShifts();
        
        public bool AddEmployeeToShift(int shiftId, int employeeId);
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

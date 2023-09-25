using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Shift 
    {
        public int ShiftID { get; set; }
        public DateOnly Date { get; set; }
        public ShiftType ShiftType { get; set; }
        public int EmployeeId { get; set; }
        public List<User> ?Employees { get; set; }
        public int numEmpl { get; set; }
        public Shift(int shiftID, DateOnly date, ShiftType shiftType, int EmployeeId, List<User> employees)
        {
            ShiftID = shiftID;
            Date = date;
            ShiftType = shiftType;
            this.EmployeeId = EmployeeId;
            Employees = employees;
        }

        public Shift()
        {
           
        }
        public Shift(int shiftID, DateOnly date, ShiftType shiftType, List<User> employees, int numEmpl)
        {
            ShiftID = shiftID;
            Date = date;
            ShiftType = shiftType;
            Employees = employees;
            this.numEmpl = numEmpl;
        }
        public Shift(int shiftID, DateOnly date, ShiftType shiftType, int numEmpl)
        {
            ShiftID = shiftID;
            Date = date;
            ShiftType = shiftType;
            this.numEmpl = numEmpl;

        }
    }
}

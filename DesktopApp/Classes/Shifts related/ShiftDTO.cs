using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ShiftDTO
    {
        public int ShiftID { get; set; }
        public DateOnly Date { get; set; }
        public int ShiftType { get; set; }
        public int EmployeeId { get; set; }
        public List<int> Employees { get; set; }
        public int numEmpl { get; set; }
        public ShiftDTO() { }
        public ShiftDTO(int shiftID, DateOnly  date, int shiftType, int employeeId, List<int> employees, int numEmpl)
        {
            ShiftID = shiftID;
            Date = date;
            ShiftType = shiftType;
            EmployeeId = employeeId;
            Employees = employees;
            this.numEmpl = numEmpl;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class DepartmentDTO
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        //public int Manager { get; set; }
        public DateOnly CreationDate { get; set; }
        public DepartmentDTO() { }
        public DepartmentDTO(int deapartmentId, string name,/* int manager,*/ DateOnly creationDate)
        {
            DepartmentId = deapartmentId;
            Name = name;
            //Manager = manager;
            CreationDate = creationDate;
        }
    }
}

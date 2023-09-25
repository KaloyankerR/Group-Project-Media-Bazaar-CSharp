using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public class Department
	{
		public int DepartmentId { get; set; }
		public string Name { get; set; }
		//public User Manager { get; set; }
		public DateOnly CreationDate { get; set; }

		public Department () 
		{ 
		}
		public Department (int id, string Name, /*User Manager*/ DateOnly CreationDate)
		{
			this.DepartmentId = id;
			this.Name = Name;
			//this.Manager = Manager;
			this.CreationDate = CreationDate;
		}

        public override string ToString()
        {
            return this.Name;
        }
    }
}

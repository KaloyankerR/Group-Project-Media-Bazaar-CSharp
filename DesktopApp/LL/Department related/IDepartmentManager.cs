using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public interface IDepartmentManager
    {
        public bool CreateDepartment(Department department);
        public bool UpdateDepartment(Department department);
        public bool DeleteDepartment(Department department);
        public Department? GetDepartmentById(int? id);
        public List<Department>? GetAllDepartments();

        public Department GetDepartmentByNameAndDate(string name, DateOnly date);
    }
}

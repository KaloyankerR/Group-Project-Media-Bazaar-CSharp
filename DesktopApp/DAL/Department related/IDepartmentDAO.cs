using Classes;
//using Classes.Department_related;

namespace DAL
{
    public interface IDepartmentDAO
    {
        bool CreateDepartment(Department department);
        bool DeleteDepartment(Department department);
        bool UpdateDepartment(Department department);
        DepartmentDTO? GetDepartmentByID(int? id);
        List<DepartmentDTO> GetAllDepartments();
        public DepartmentDTO GetDepartmentByNameAndDate(string name, DateOnly date);
    }
}

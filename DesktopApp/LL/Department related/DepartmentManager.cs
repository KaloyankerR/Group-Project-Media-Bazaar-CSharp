using DAL;
using LL;

namespace Classes
{
    public class DepartmentManager:IDepartmentManager
    {
        IDepartmentDAO departmentDAO;
        
        public DepartmentManager(IDepartmentDAO departmentDAO)
        {
            this.departmentDAO = departmentDAO;
        }

        public bool CreateDepartment (Department department)
        {
            try
            {
                if (departmentDAO.CreateDepartment(department))
                    return true;
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DeleteDepartment (Department department)
        {
            try
            {
                if (departmentDAO.DeleteDepartment(department))
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<Department> GetAllDepartments() 
        {
            Department department;
            List<Department> departments = new List<Department>() ;

            try
            {
                foreach (DepartmentDTO departmentDTO in departmentDAO.GetAllDepartments())
                {
                    department = new Department(departmentDTO.DepartmentId, departmentDTO.Name, departmentDTO.CreationDate);
                    departments.Add(department);
                }
                return departments;
            }
            catch (Exception ex) 
            {
                return null;
            }
            
            
        }
        public bool UpdateDepartment(Department department)
        {
            try
            {
                if (departmentDAO.UpdateDepartment(department))
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Department? GetDepartmentById(int? id)
        {
            Department department = new();
			DepartmentDTO? departmentDTO = departmentDAO.GetDepartmentByID(id);
			if (departmentDTO != null)
			{
				department = new Department(departmentDTO.DepartmentId, departmentDTO.Name, departmentDTO.CreationDate);
			}
			return department;
		}

        public Department GetDepartmentByNameAndDate(string name, DateOnly date)
        {
            Department department = new();
            DepartmentDTO departmentDTO = departmentDAO.GetDepartmentByNameAndDate(name, date);
            if (departmentDTO != null)
            {
                department = new Department(departmentDTO.DepartmentId, departmentDTO.Name, departmentDTO.CreationDate);
            }
            return department;
        }
    }
}


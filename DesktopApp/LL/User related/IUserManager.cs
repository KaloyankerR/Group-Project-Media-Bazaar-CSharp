using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
	public interface IUserManager
	{
		bool CreateUser(User user, Address address);
		bool DeleteUser(User user, Address address);
		int GetIdOfEmployeeByEmail(string email);
        bool UpdateUser(User user, Address address);
		List<User> GetAllUsers();
		User GetUserByID(int id);
		bool UserExistsByEmail(string email);
        List<User> GetUsersByDepartment(Department department);
		int GetUserIdByFirstNameAndLastName(string first, string last);
        List<User> GetUsersByShiftID(int id);
        public List<User> GetAllManagersWithoutDepartment();

        public User GetManagerByDepartmentId(int id);

        public List<User> EmployeeWithPreferedScheduleByDepartment(int department_id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace DAL
{
	public interface IUserDAO
	{
		bool CreateUser(User user);
		bool DeleteUser(User user);
		bool UpdateUser(User user);
		List<UserDTO> GetAllUsers();
		UserDTO GetUserByID(int id);
		int GetIdOfEmployeeByEmail(string email);
        UserDTO Login(string email, string password);
		bool UserExistsByEmail(string email);
		string GetSalt(string email);
		List<UserDTO> GetUsersByDepartment(Department department);
		int GetUserIdByFirstNameAndLastName(string first, string last);
		List<UserDTO> GetUsersByShiftID(int id);
		public List<UserDTO> GetAllManagersWithoutDepartment();
		public UserDTO GetManagerByDepartmentId(int id);

		public List<UserDTO> EmployeeWithPreferedScheduleByDepartment(int department_id);
    }
}

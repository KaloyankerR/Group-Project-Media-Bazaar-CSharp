using Classes;
using DAL;
using LL.User_related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
	public class UserManager : IUserManager
	{
		IUserDAO userDAO;
		AddressDAO addressDAO = new();
        

        public UserManager(IUserDAO userDAO)
		{
			this.userDAO = userDAO;
		}

        public bool CreateUser(User user, Address address)
        {
            try
			{
                if (addressDAO.AddAddress(address) && userDAO.CreateUser(user))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
			catch (Exception)
			{
				return false;
			}
		}

		public bool DeleteUser(User user, Address address)
		{
            try
            {
                if (userDAO.DeleteUser(user) && addressDAO.DeleteAddress(address))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

		public List<User> GetAllUsers()
		{
            DepartmentManager departmentManager = new(new DepartmentDAO());
            User user;
            List<User> users = new List<User>();

            foreach (UserDTO userDTO in userDAO.GetAllUsers())
            {
                Address address = addressDAO.GetAddressByID(userDTO.Address);
                Gender gender = (Gender)userDTO.Gender;
                UserType userType = (UserType)userDTO.UserType;
                Department department = departmentManager.GetDepartmentById(userDTO.Department);
                user = new User(userDTO.UserID, userDTO.Email, userDTO.Password, userDTO.FirstName, userDTO.LastName, userDTO.DateOfBirth, address, userDTO.PhoneNumber, gender, userDTO.BSN, userType, department);
                users.Add(user);
            }
            return users;

        }

        public User GetUserByID(int id)
		{
			DepartmentManager departmentManager = new(new DepartmentDAO());
			User user;
			UserDTO userDTO = userDAO.GetUserByID(id);
			Address address = addressDAO.GetAddressByID(userDTO.Address);
			Gender gender = (Gender)userDTO.Gender;
			UserType userType = (UserType)userDTO.UserType;
			Department? department = departmentManager.GetDepartmentById(userDTO.Department);
			user = new User(userDTO.UserID, userDTO.Email, userDTO.Password, userDTO.FirstName, userDTO.LastName, userDTO.DateOfBirth, address, userDTO.PhoneNumber, gender, userDTO.BSN, userType, department);
			return user;
		}

        public int GetUserIdByFirstNameAndLastName(string first, string last)
        {

            return userDAO.GetUserIdByFirstNameAndLastName(first, last);
        }

        public int GetIdOfEmployeeByEmail(string email)
        {
            
            return  userDAO.GetIdOfEmployeeByEmail(email);
        }

        public bool UpdateUser(User user, Address address)
		{
            try
            {
                if (addressDAO.UpdateAddress(address) && userDAO.UpdateUser(user))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

		public bool UserExistsByEmail(string email)
		{
            return userDAO.UserExistsByEmail(email);
        }

        public List<User> GetUsersByDepartment(Department department)
        {
            User user;
            List<User> users = new List<User>();

            foreach (UserDTO userDTO in userDAO.GetUsersByDepartment(department))
            {
                Address address = addressDAO.GetAddressByID(userDTO.Address);
                Gender gender = (Gender)userDTO.Gender;
                UserType userType = (UserType)userDTO.UserType;
                user = new User(userDTO.UserID, userDTO.Email, userDTO.Password, userDTO.FirstName, userDTO.LastName, userDTO.DateOfBirth, address, userDTO.PhoneNumber, gender, userDTO.BSN, userType, department);
                users.Add(user);
            }
            return users;
        }

        public List<User> GetUsersByShiftID(int id)
        {
            DepartmentManager departmentManager = new(new DepartmentDAO());
            User user;
            List<User> users = new List<User>();

            foreach (UserDTO userDTO in userDAO.GetUsersByShiftID(id))
            {
                Address address = addressDAO.GetAddressByID(userDTO.Address);
                Gender gender = (Gender)userDTO.Gender;
                UserType userType = (UserType)userDTO.UserType;
                Department department = departmentManager.GetDepartmentById(userDTO.Department);
                user = new User(userDTO.UserID, userDTO.Email, userDTO.Password, userDTO.FirstName, userDTO.LastName, userDTO.DateOfBirth, address, userDTO.PhoneNumber, gender, userDTO.BSN, userType, department);
                users.Add(user);
            }
            return users;
        }
        public List<User> GetAllManagersWithoutDepartment()
        {
            DepartmentManager departmentManager = new(new DepartmentDAO());
            User user;
            List<User> users = new List<User>();
            foreach (UserDTO userDTO in userDAO.GetAllManagersWithoutDepartment())
            {
                Address address = addressDAO.GetAddressByID(userDTO.Address);
                Gender gender = (Gender)userDTO.Gender;
                UserType userType = (UserType)userDTO.UserType;
                Department department = departmentManager.GetDepartmentById(userDTO.Department);
                user = new User(userDTO.UserID, userDTO.Email, userDTO.Password, userDTO.FirstName, userDTO.LastName, userDTO.DateOfBirth, address, userDTO.PhoneNumber, gender, userDTO.BSN, userType, department);
                users.Add(user);
            }
            return users;
                
        }

        public User GetManagerByDepartmentId(int id)
        {
            DepartmentManager departmentManager = new(new DepartmentDAO());
            User user;
            UserDTO userDTO = userDAO.GetManagerByDepartmentId(id);
            Address address = addressDAO.GetAddressByID(userDTO.Address);
            Gender gender = (Gender)userDTO.Gender;
            UserType userType = (UserType)userDTO.UserType;
            Department? department = departmentManager.GetDepartmentById(userDTO.Department);
            user = new User(userDTO.UserID, userDTO.Email, userDTO.Password, userDTO.FirstName, userDTO.LastName, userDTO.DateOfBirth, address, userDTO.PhoneNumber, gender, userDTO.BSN, userType, department);
            return user;
        }

        public List<User> EmployeeWithPreferedScheduleByDepartment(int department_id)
        {
            DepartmentManager departmentManager = new(new DepartmentDAO());
            User user;
            List<User> users = new List<User>();
            foreach (UserDTO userDTO in userDAO.EmployeeWithPreferedScheduleByDepartment(department_id))
            {
                Address address = addressDAO.GetAddressByID(userDTO.Address);
                Gender gender = (Gender)userDTO.Gender;
                UserType userType = (UserType)userDTO.UserType;
                Department department = departmentManager.GetDepartmentById(department_id);
                user = new User(userDTO.UserID, userDTO.Email, userDTO.Password, userDTO.FirstName, userDTO.LastName, userDTO.DateOfBirth, address, userDTO.PhoneNumber, gender, userDTO.BSN, userType, department);
                users.Add(user);
            }
            return users;
        }
    }
}

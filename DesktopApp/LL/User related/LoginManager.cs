using Classes;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LL.User_related
{
	public class LoginManager
	{
        IUserDAO userDAO;
		AddressDAO addressDAO = new();
        IDepartmentManager departmentManager = new DepartmentManager(new DepartmentDAO());

        public LoginManager(IUserDAO userDAO)
		{
			this.userDAO = userDAO;
		}

		public User Login(string email, string password)
		{
            User user;
            UserDTO userDTO = userDAO.Login(email, password);
			if (userDTO != null)
			{
                Address address = addressDAO.GetAddressByID(userDTO.Address);
                Gender gender = (Gender)userDTO.Gender;
                UserType userType = (UserType)userDTO.UserType;
                Department? department = departmentManager.GetDepartmentById(userDTO.Department);
                user = new User(userDTO.UserID, userDTO.Email, userDTO.Password, userDTO.FirstName, userDTO.LastName, userDTO.DateOfBirth, address, userDTO.PhoneNumber, gender, userDTO.BSN, userType, department);
				return user;
			}
			else
			{
				return null;
			}
		}
    }
}

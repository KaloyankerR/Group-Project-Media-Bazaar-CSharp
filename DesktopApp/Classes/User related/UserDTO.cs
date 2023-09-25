using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public class UserDTO
	{
		public int UserID { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateOnly DateOfBirth { get; set; }
		public int Address { get; set; }
		public string PhoneNumber { get; set; }
		public int Gender { get; set; }
		public int BSN { get; set; }
		public int UserType { get; set; }
		public int? Department { get; set; }

		public UserDTO()
		{

		}

		public UserDTO(int userID, string email, string password, string firstName, string lastName, DateOnly dateOfBirth, int address, string phoneNumber, int gender, int bsn, int userType, int? department)
		{
			UserID = userID;
			Email = email;
			Password = password;
			FirstName = firstName;
			LastName = lastName;
			DateOfBirth = dateOfBirth;
			Address = address;
			PhoneNumber = phoneNumber;
			Gender = gender;
			BSN = bsn;
			UserType = userType;
			Department = department;
		}
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}

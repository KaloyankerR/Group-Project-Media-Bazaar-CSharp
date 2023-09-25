using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public class User
	{
		public int UserID { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateOnly DateOfBirth { get; set; }
		public Address Address { get; set; }
		public string PhoneNumber { get; set; }
		public Gender Gender { get; set; }
		public int BSN { get; set; }
		public UserType UserType { get; set; }
		public Department? Department { get; set; }

		public User()
		{
			
		}

		public User(int userID, string email, string password, string firstName, string lastName, DateOnly dateOfBirth, Address address, string phoneNumber, Gender gender, int bsn, UserType userType, Department? department)
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
            return this.FirstName+ " "+this.LastName;
        }

    }
}

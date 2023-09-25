using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public class Address
	{
		public int AddressID { get; set; }
		public string StreetName { get; set; }
		public string HouseNumber { get; set; }
		public string ZIPCode { get; set; }
		public string City { get; set; }
		public string Country { get; set; }

		public Address()
		{
			
		}
		
		public Address(int id, string name, string number, string zipcode, string city, string country)
		{
			AddressID = id;
			StreetName = name;
			HouseNumber = number;
			ZIPCode = zipcode;
			City = city;
			Country = country;
		}

	}
}
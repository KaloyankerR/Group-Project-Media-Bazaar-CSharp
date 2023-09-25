using Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class AddressDAO : Repository
	{
		public bool AddAddress(Address address)
		{
			using SqlConnection conn = new SqlConnection(ConnectionString);
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand("INSERT INTO Address (streetname, housenumber, zipcode, city, country) VALUES (@streetname, @housenumber, @zipcode, @city, @country)", conn);
				cmd.Parameters.AddWithValue("@streetname", address.StreetName);
				cmd.Parameters.AddWithValue("@housenumber", address.HouseNumber);
				cmd.Parameters.AddWithValue("@zipcode", address.ZIPCode);
				cmd.Parameters.AddWithValue("@city", address.City);
				cmd.Parameters.AddWithValue("@country", address.Country);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool DeleteAddress(Address address)
		{
			using SqlConnection conn = new SqlConnection(ConnectionString);
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand("DELETE FROM Address WHERE addressid = @addressid", conn);
				cmd.Parameters.AddWithValue("@addressid", address.AddressID);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool UpdateAddress(Address address)
		{
			using SqlConnection conn = new SqlConnection(ConnectionString);
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand("UPDATE Address SET streetname = @streetname, housenumber = @housenumber, zipcode = @zipcode, city = @city, country = @country WHERE addressid = @addressid", conn);
				cmd.Parameters.AddWithValue("@streetname", address.StreetName);
				cmd.Parameters.AddWithValue("@housenumber", address.HouseNumber);
				cmd.Parameters.AddWithValue("@zipcode", address.ZIPCode);
				cmd.Parameters.AddWithValue("@city", address.City);
				cmd.Parameters.AddWithValue("@country", address.Country);
				cmd.Parameters.AddWithValue("@addressid", address.AddressID);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public Address GetAddressByID(int addressID)
		{
			using SqlConnection conn = new SqlConnection(ConnectionString);
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand("SELECT * FROM Address WHERE addressid = @addressid", conn);
				cmd.Parameters.AddWithValue("@addressid", addressID);
				SqlDataReader reader = cmd.ExecuteReader();
				Address address = new Address();
				while (reader.Read())
				{
					address.AddressID = reader.GetInt32("addressid");
					address.StreetName = reader.GetString("streetname");
					address.HouseNumber = reader.GetString("housenumber");
					address.ZIPCode = reader.GetString("zipcode");
					address.City = reader.GetString("city");
					address.Country = reader.GetString("country");
				}
				return address;
			}
			catch (Exception)
			{
				return null;
			}
		}

		public Address GetLatestAddress()
		{
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Address ORDER BY addressid DESC LIMIT 1", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                Address address = new Address();
                while (reader.Read())
                {
                    address.AddressID = reader.GetInt32("addressid");
                    address.StreetName = reader.GetString("streetname");
                    address.HouseNumber = reader.GetString("housenumber");
                    address.ZIPCode = reader.GetString("zipcode");
                    address.City = reader.GetString("city");
                    address.Country = reader.GetString("country");
                }
                return address;
            }
            catch (Exception)
            {
                return null;
            }
        }
	}
}

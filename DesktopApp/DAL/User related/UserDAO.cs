using Classes;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
	public class UserDAO : Repository, IUserDAO
	{
		public bool CreateUser(User user)
		{
			using SqlConnection conn = new SqlConnection(ConnectionString);
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand("INSERT INTO [User] (email, password, firstname, lastname, dateofbirth, addressid, phonenumber, gender, bsn, usertype, departmentid, salt) VALUES (@email, @password, @firstname, @lastname, @dateofbirth, (SELECT MAX(addressid) FROM Address), @phonenumber, @gender, @bsn, @usertype, @departmentid, @salt)", conn);

				string randomSalt = BCrypt.Net.BCrypt.GenerateSalt();
				string hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password, randomSalt);
				user.Password = hashedPassword;

				DateTime dateOfBirth = new DateTime(user.DateOfBirth.Year, user.DateOfBirth.Month, user.DateOfBirth.Day);

				cmd.Parameters.AddWithValue("@email", user.Email);
				cmd.Parameters.AddWithValue("@password", user.Password);
				cmd.Parameters.AddWithValue("@firstname", user.FirstName);
				cmd.Parameters.AddWithValue("@lastname", user.LastName);
				cmd.Parameters.AddWithValue("dateofbirth", dateOfBirth);
				cmd.Parameters.AddWithValue("@phonenumber", user.PhoneNumber);
				cmd.Parameters.AddWithValue("@gender", user.Gender);
				cmd.Parameters.AddWithValue("@bsn", user.BSN);
				cmd.Parameters.AddWithValue("@usertype", user.UserType);
                cmd.Parameters.AddWithValue("@departmentid", (object)user.Department?.DepartmentId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@salt", randomSalt);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (SqlException)
			{
				return false;
			}
		}

		public bool DeleteUser(User user)
		{
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [User] WHERE id=@id", conn);
				cmd.Parameters.AddWithValue("@id", user.UserID);
				cmd.ExecuteNonQuery();
                
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
		
		public List<UserDTO> GetAllUsers()
		{
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                List<UserDTO> users = new List<UserDTO>();

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [User]", conn);
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					UserDTO user = new UserDTO();
                    user.UserID = reader.GetInt32("id");
                    user.Email = reader.GetString("email");
                    user.Password = reader.GetString("password");
                    user.FirstName = reader.GetString("firstname");
                    user.LastName = reader.GetString("lastname");
                    user.DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("dateofbirth"));
                    user.Address = reader.GetInt32("addressid");
                    user.PhoneNumber = reader.GetString("phonenumber");
                    user.Gender = reader.GetInt32("gender");
                    user.BSN = Convert.ToInt32(reader.GetString("bsn"));
                    user.UserType = reader.GetInt32("usertype");
                    user.Department = reader.IsDBNull(reader.GetOrdinal("departmentid")) ? null : reader.GetInt32("departmentid");
					users.Add(user);
				}
                return users;
            }
            catch (SqlException)
            {
                return null;
            }
		}

		public string GetSalt(string email)
		{
			using SqlConnection conn = new SqlConnection(ConnectionString);
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand("SELECT salt FROM [User] WHERE email = @email", conn);
				cmd.Parameters.AddWithValue("@email", email);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					return reader.GetString("salt");
				}
				else
				{
					return null;
				}
			}
			catch (SqlException)
			{
				return null;
			}
		}

		public UserDTO GetUserByID(int id)
		{
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                UserDTO user = new UserDTO();

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
                        user.UserID = reader.GetInt32("id");
                        user.Email = reader.GetString("email");
                        user.Password = reader.GetString("password");
                        user.FirstName = reader.GetString("firstname");
                        user.LastName = reader.GetString("lastname");
                        user.DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("dateofbirth"));
                        user.Address = reader.GetInt32("addressid");
                        user.PhoneNumber = reader.GetString("phonenumber");
                        user.Gender = reader.GetInt32("gender");
						user.BSN = Convert.ToInt32(reader.GetString("bsn"));
						user.UserType = reader.GetInt32("usertype");
                        user.Department = reader.IsDBNull(reader.GetOrdinal("departmentid")) ? null : reader.GetInt32("departmentid");

                        return user;
                    } 
					else
					{
						return user;
					}
				}
                
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public int GetIdOfEmployeeByEmail(string email)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                UserDTO user = new UserDTO();

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE email=@email", conn);
                cmd.Parameters.AddWithValue("@email", email);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user.UserID = reader.GetInt32("id");
                        user.Email = reader.GetString("email");
                        user.Password = reader.GetString("password");
                        user.FirstName = reader.GetString("firstname");
                        user.LastName = reader.GetString("lastname");
                        user.DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("dateofbirth"));
                        user.Address = reader.GetInt32("addressid");
                        user.PhoneNumber = reader.GetString("phonenumber");
                        user.Gender = reader.GetInt32("gender");
                        user.BSN = Convert.ToInt32(reader.GetString("bsn"));
                        user.UserType = reader.GetInt32("usertype");
                        user.Department = reader.IsDBNull(reader.GetOrdinal("departmentid")) ? null : reader.GetInt32("departmentid");

                        return user.UserID;
                    }
                    else
                    {
                        return user.UserID;
                    }
                }

            }
            catch (SqlException)
            {
                return 0;
            }
        }
        public UserDTO Login(string email, string password)
		{
			using SqlConnection conn = new SqlConnection(ConnectionString);
			try
			{
				string salt = GetSalt(email);
				string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
				conn.Open();
				SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE email = @email AND password = @password", conn);
				cmd.Parameters.AddWithValue("@email", email);
				cmd.Parameters.AddWithValue("@password", hashedPassword);
				SqlDataReader reader = cmd.ExecuteReader();
				UserDTO user = new UserDTO();
				if (reader.Read())
				{
					user.UserID = reader.GetInt32("id");
					user.Email = reader.GetString("email");
					user.Password = reader.GetString("password");
					user.FirstName = reader.GetString("firstname");
					user.LastName = reader.GetString("lastname");
					user.DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("dateofbirth"));
					user.Address = reader.GetInt32("addressid");
					user.PhoneNumber = reader.GetString("phonenumber");
					user.Gender = reader.GetInt32("gender");
					user.BSN = Convert.ToInt32(reader.GetString("bsn"));
					user.UserType = reader.GetInt32("usertype");
					user.Department = reader.IsDBNull(reader.GetOrdinal("departmentid")) ? null : reader.GetInt32("departmentid");
					return user;
				}
				else
				{
					return null;
				}
			}
			catch (Exception)
			{
				return null;
			}
		}

		public bool UpdateUser(User user)
		{
			using SqlConnection conn = new SqlConnection(ConnectionString);
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand("UPDATE [User] SET email=@email, firstname=@firstname, lastname=@lastname, dateofbirth=@dateofbirth, addressid=@addressid, phonenumber=@phonenumber, gender=@gender, bsn=@bsn, usertype=@usertype, departmentid=@departmentid WHERE id = @Id", conn);
                DateTime date = new DateTime(user.DateOfBirth.Year, user.DateOfBirth.Month, user.DateOfBirth.Day);
				//string randomSalt = BCrypt.Net.BCrypt.GenerateSalt();
				//string hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password, randomSalt);
				//user.Password = hashedPassword;

				cmd.Parameters.AddWithValue("@email", user.Email);
				//cmd.Parameters.AddWithValue("@password", hashedPassword);
				cmd.Parameters.AddWithValue("@firstname", user.FirstName);
				cmd.Parameters.AddWithValue("@lastname", user.LastName);
				cmd.Parameters.AddWithValue("@dateofbirth", date);
				cmd.Parameters.AddWithValue("@addressid", user.Address.AddressID);
				cmd.Parameters.AddWithValue("@phonenumber", user.PhoneNumber);
				cmd.Parameters.AddWithValue("@gender", user.Gender);
				cmd.Parameters.AddWithValue("@bsn", user.BSN);
				cmd.Parameters.AddWithValue("@usertype", user.UserType);
                if (user.Department == null)
                {
                    cmd.Parameters.AddWithValue("@departmentid", DBNull.Value);
                }
                else
                {
				    cmd.Parameters.AddWithValue("@departmentid", user.Department?.DepartmentId);
                }
				//cmd.Parameters.AddWithValue("@salt", randomSalt);
				cmd.Parameters.AddWithValue("@Id", user.UserID);

				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool UserExistsByEmail(string email)
		{
			using SqlConnection conn = new SqlConnection(ConnectionString);
			try 
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE email = @email", conn);
				cmd.Parameters.AddWithValue("@email", email);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
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

        public List<UserDTO> GetUsersByDepartment(Department department)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                List<UserDTO> users = new List<UserDTO>();

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE departmentid = @departmentid", conn);
                cmd.Parameters.AddWithValue("@departmentid", department.DepartmentId);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    UserDTO user = new UserDTO();
                    user.UserID = reader.GetInt32("id");
                    user.Email = reader.GetString("email");
                    user.Password = reader.GetString("password");
                    user.FirstName = reader.GetString("firstname");
                    user.LastName = reader.GetString("lastname");
                    user.DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("dateofbirth"));
                    user.Address = reader.GetInt32("addressid");
                    user.PhoneNumber = reader.GetString("phonenumber");
                    user.Gender = reader.GetInt32("gender");
                    user.BSN = Convert.ToInt32(reader.GetString("bsn"));
                    user.UserType = reader.GetInt32("usertype");
                    //user.Department = reader.IsDBNull(reader.GetOrdinal("departmentid")) ? null : reader.GetInt32("departmentid");
                    users.Add(user);
                }
                return users;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public int GetUserIdByFirstNameAndLastName(string first, string last)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                UserDTO user = new UserDTO();

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE firstname=@firstname AND lastname=@lastname", conn);
                cmd.Parameters.AddWithValue("@firstname", first);
                cmd.Parameters.AddWithValue("@lastname", last);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user.UserID = reader.GetInt32("id");
                        user.Email = reader.GetString("email");
                        user.Password = reader.GetString("password");
                        user.FirstName = reader.GetString("firstname");
                        user.LastName = reader.GetString("lastname");
                        user.DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("dateofbirth"));
                        user.Address = reader.GetInt32("addressid");
                        user.PhoneNumber = reader.GetString("phonenumber");
                        user.Gender = reader.GetInt32("gender");
                        user.BSN = Convert.ToInt32(reader.GetString("bsn"));
                        user.UserType = reader.GetInt32("usertype");
                        user.Department = reader.IsDBNull(reader.GetOrdinal("departmentid")) ? null : reader.GetInt32("departmentid");

                        return user.UserID;
                    }
                    else
                    {
                        return user.UserID;
                    }
                }

            }
            catch (SqlException)
            {
                return 0;
            }
        }

        public List<UserDTO> GetUsersByShiftID(int id)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                List<UserDTO> users = new List<UserDTO>();

                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from [User] u join Shift_Relation sr on sr.employee_id = u.id where sr.shift_id=@shiftid", conn);
                cmd.Parameters.AddWithValue("@shiftid", id);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    UserDTO user = new UserDTO();
                    user.UserID = reader.GetInt32("id");
                    user.Email = reader.GetString("email");
                    user.Password = reader.GetString("password");
                    user.FirstName = reader.GetString("firstname");
                    user.LastName = reader.GetString("lastname");
                    user.DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("dateofbirth"));
                    user.Address = reader.GetInt32("addressid");
                    user.PhoneNumber = reader.GetString("phonenumber");
                    user.Gender = reader.GetInt32("gender");
                    user.BSN = Convert.ToInt32(reader.GetString("bsn"));
                    user.UserType = reader.GetInt32("usertype");
                    //user.Department = reader.IsDBNull(reader.GetOrdinal("departmentid")) ? null : reader.GetInt32("departmentid");
                    users.Add(user);
                }
                return users;
            }
            catch (SqlException)
            {
                return null;
            }
        }
        public List<UserDTO>GetAllManagersWithoutDepartment()
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            {
                try
                {
                    List<UserDTO> users = new List<UserDTO>();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [User] AS u WHERE u.usertype=3 AND departmentid is NULL", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        UserDTO user = new UserDTO();
                        user.UserID = reader.GetInt32("id");
                        user.Email = reader.GetString("email");
                        user.Password = reader.GetString("password");
                        user.FirstName = reader.GetString("firstname");
                        user.LastName = reader.GetString("lastname");
                        user.DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("dateofbirth"));
                        user.Address = reader.GetInt32("addressid");
                        user.PhoneNumber = reader.GetString("phonenumber");
                        user.Gender = reader.GetInt32("gender");
                        user.BSN = Convert.ToInt32(reader.GetString("bsn"));
                        user.UserType = reader.GetInt32("usertype");
                        //user.Department = reader.IsDBNull(reader.GetOrdinal("departmentid")) ? null : reader.GetInt32("departmentid");
                        users.Add(user);
                    }
                    return users;
                }
                catch (SqlException)
                {
                    return null;
                }
            }
        }

        public UserDTO GetManagerByDepartmentId(int id)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            {
                try
                {
                    UserDTO user = new UserDTO();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE usertype=3 AND departmentid=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.Read())
                    {
                        user.UserID = reader.GetInt32("id");
                        user.Email = reader.GetString("email");
                        user.Password = reader.GetString("password");
                        user.FirstName = reader.GetString("firstname");
                        user.LastName = reader.GetString("lastname");
                        user.DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("dateofbirth"));
                        user.Address = reader.GetInt32("addressid");
                        user.PhoneNumber = reader.GetString("phonenumber");
                        user.Gender = reader.GetInt32("gender");
                        user.BSN = Convert.ToInt32(reader.GetString("bsn"));
                        user.UserType = reader.GetInt32("usertype");
                        user.Department = reader.IsDBNull(reader.GetOrdinal("departmentid")) ? null : reader.GetInt32("departmentid");
                    }
                    return user;
                }
                catch (SqlException)
                {
                    return null;
                }
            }
        }

        public List<UserDTO> EmployeeWithPreferedScheduleByDepartment(int department_id)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                List<UserDTO> users = new List<UserDTO>();
                conn.Open();
                SqlCommand cmd = new("SELECT DISTINCT U.* FROM[User] AS U JOIN[Prefered Schedule] AS P ON U.id = P.employee_id WHERE U.departmentid =@department_id", conn);
                cmd.Parameters.AddWithValue("@department_id", department_id);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    UserDTO user = new UserDTO();
                    user.UserID = reader.GetInt32("id");
                    user.Email = reader.GetString("email");
                    user.Password = reader.GetString("password");
                    user.FirstName = reader.GetString("firstname");
                    user.LastName = reader.GetString("lastname");
                    user.DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("dateofbirth"));
                    user.Address = reader.GetInt32("addressid");
                    user.PhoneNumber = reader.GetString("phonenumber");
                    user.Gender = reader.GetInt32("gender");
                    user.BSN = Convert.ToInt32(reader.GetString("bsn"));
                    user.UserType = reader.GetInt32("usertype");
                    user.Department = reader.IsDBNull(reader.GetOrdinal("departmentid")) ? null : reader.GetInt32("departmentid");
                    users.Add(user);
                }
                return users;
            }
            catch (SqlException)
            {
                return null;
            }
        }
    }
}


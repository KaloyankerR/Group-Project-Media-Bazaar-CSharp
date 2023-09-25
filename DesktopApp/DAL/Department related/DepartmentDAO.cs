using Classes;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class DepartmentDAO : Repository, IDepartmentDAO
    {
        public bool CreateDepartment(Department department)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
            
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Department](name, creation_date) VALUES( @name, @creation_date)", conn);
                cmd.Parameters.AddWithValue("@name", department.Name);
                cmd.Parameters.AddWithValue("@creation_date",new DateTime( department.CreationDate.Year,department.CreationDate.Month,department.CreationDate.Day));
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }
        public bool DeleteDepartment(Department department)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Department WHERE department_id=@department_id", conn);
                cmd.Parameters.AddWithValue("@department_id", department.DepartmentId);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateDepartment(Department department)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Department SET  name=@name,  creation_date=@creation_date", conn);
                //cmd.Parameters.AddWithValue("@department_id", department.DeapartmentId);
                cmd.Parameters.AddWithValue("@name", department.Name);
                //cmd.Parameters.AddWithValue("@manager_id", department.Manager);
                cmd.Parameters.AddWithValue("@creation_date", department.CreationDate);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
		public DepartmentDTO? GetDepartmentByID(int? id)
		{
            if (id == null)
            {
                return null;
            }

            using SqlConnection conn = new SqlConnection(ConnectionString);
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand("SELECT * FROM Department WHERE department_id=@department_id", conn);
				cmd.Parameters.AddWithValue("@department_id", id);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					DepartmentDTO department = new();
					department.DepartmentId = reader.GetInt32("department_id");
					department.Name = reader.GetString("name");
					department.CreationDate = DateOnly.FromDateTime(reader.GetDateTime("creation_date"));
					return department;
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
		public List<DepartmentDTO> GetAllDepartments()
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                List<DepartmentDTO> departments = new List<DepartmentDTO>();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Department", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DepartmentDTO department = new DepartmentDTO();
                    department.DepartmentId = reader.GetInt32("department_id");
                    department.Name = reader.GetString("name");
                    department.CreationDate = DateOnly.FromDateTime(reader.GetDateTime("creation_date"));
                    //department.Manager = reader.GetInt32("manager_id");
                    departments.Add(department);
                }
                return departments;
            }
            catch (SqlException ex)
            {
                return null;
            }
        } 
        
        public DepartmentDTO GetDepartmentByNameAndDate(string name,DateOnly date)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            {
                try
                {
                    DateTime dateTime = new(date.Year, date.Month, date.Day);
                    DepartmentDTO department = new DepartmentDTO(); 
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Department AS d WHERE d.creation_date=@date AND d.[name]=@name", conn);
                    cmd.Parameters.AddWithValue("@name",name);
                    cmd.Parameters.AddWithValue("@date",dateTime);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        department.DepartmentId = reader.GetInt32("department_id");
                        department.Name = reader.GetString("name");
                        department.CreationDate = DateOnly.FromDateTime(reader.GetDateTime("creation_date"));
                    }
                    return department;
                }
                catch (SqlException ex)
                {
                    return null;
                }
            }
        }
    }
}

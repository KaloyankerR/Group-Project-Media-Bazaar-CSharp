using Classes;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class ShiftDAO: Repository, IShiftDAO
    {        

        public bool CreateShift(DateOnly date, int type, List<int> employees, int numEmpl)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {   conn.Open();
                    foreach(int emp in employees)
                    {
                        
                        SqlCommand cmd = new SqlCommand("INSERT INTO [Shift] (date, shift_type_id, numberofemployees) VALUES (@date, @shift_type_id, @numberofemployees)", conn);
                        DateTime Date = new DateTime(date.Year, date.Month, date.Day);
                        cmd.Parameters.AddWithValue("@date", Date);
                        cmd.Parameters.AddWithValue("@shift_type_id", type);
                        cmd.Parameters.AddWithValue("@numberofemployees", numEmpl);
                        cmd.ExecuteNonQuery();

                        
                        SqlCommand cmd1 = new SqlCommand("INSERT INTO [Shift_Relation] (shift_id, employee_id) VALUES ((SELECT MAX(shift_id) FROM [Shift]), @employee_id)", conn);
                        cmd1.Parameters.AddWithValue("@employee_id", emp);
                        cmd1.ExecuteNonQuery();

                    }
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }

        public bool DeleteShift(DateOnly date, int type)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM [Shift_Relation] WHERE shift_id IN ( SELECT s.shift_id FROM [Shift] s WHERE s.date = @date AND s.shift_type_id = @shift_type_id); DELETE FROM [Shift] WHERE date = @date AND shift_type_id = @shift_type_id", conn);
                    DateTime Date = new DateTime(date.Year, date.Month, date.Day);
                    cmd.Parameters.AddWithValue("@date", Date);
                    cmd.Parameters.AddWithValue("@shift_type_id", type);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    return false;
                }
            }
        }

        public List<ShiftDTO> GetScheduleByShiftId(int id)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT employee_id,Shift.date, Shift.shift_type_id  FROM Shift_Relation JOIN Shift ON Shift_Relation.shift_id=Shift.shift_id WHERE  Shift.shift_id=@shift_id", conn);
                cmd.Parameters.AddWithValue("@shift_id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                List<ShiftDTO> shifts = new List<ShiftDTO>();
                while (reader.Read()) 
                {
                    ShiftDTO shift = new ShiftDTO();
                    shift.ShiftID = reader.GetInt32("shift_id");
                    shift.Date = DateOnly.FromDateTime(reader.GetDateTime("date"));
                    shift.ShiftType = reader.GetInt32("shift_type_id");
                    shift.EmployeeId = reader.GetInt32("employee_id");
                    shifts.Add(shift);
                }
                return shifts;

            }
            catch (Exception ex)
            {
                return null;
            }
                
        }
        public List<ShiftDTO> GetScheduleByShiftTypeAndDate(DateOnly date, int type, string department)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT s.* FROM Shift AS s Join Shift_Relation AS sr On s.shift_id=sr.shift_id JOIN [User] as u on sr.employee_id=u.id Join Department as d on d.department_id=u.departmentid Where s.shift_type_id = @shift_type_id and s.date=@date and d.name=@name", conn);
                DateTime Date = new DateTime(date.Year, date.Month, date.Day);
                cmd.Parameters.AddWithValue("@date", Date);
                cmd.Parameters.AddWithValue("@shift_type_id", type);
                cmd.Parameters.AddWithValue("@name", department);
                SqlDataReader reader = cmd.ExecuteReader();
                List<ShiftDTO> shifts = new List<ShiftDTO>();
                while (reader.Read())
                {
                    ShiftDTO shift = new ShiftDTO();
                    shift.Date = DateOnly.FromDateTime(reader.GetDateTime("date"));
                    shift.ShiftType = reader.GetInt32("shift_type_id");
                    shift.ShiftID = reader.GetInt32("shift_id");
                    shift.numEmpl = reader.GetInt32("numberofemployees");
                    shifts.Add(shift);
                }
                return shifts;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public ShiftDTO GetShiftEmployeeId(int id)
        {

            using SqlConnection conn = new SqlConnection(ConnectionString);
            {
                

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Shift.shift_id, Shift.date, Shift.shift_type_id  FROM Shift_Relation JOIN Shift ON Shift_Relation.shift_id=Shift.shift_id WHERE Shift_Relation.employee_id=@employee_id ", conn);
                    cmd.Parameters.AddWithValue("employee_id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    ShiftDTO shift = new ShiftDTO();

                    while (reader.Read())
                    {

                        shift.ShiftID = reader.GetInt32("shift_id");
                        shift.Date = DateOnly.FromDateTime(reader.GetDateTime("date"));
                        shift.ShiftType = reader.GetInt32("shift_type_id");
                        shift.EmployeeId = reader.GetInt32("employee_id");
                        
                    }
                    return shift;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    return null;
                }
            }
        }
        public ShiftDTO GetShiftEmployeeByTypeId(int type)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT shift_id, date, Shift_Relation.employee_id FROM Shift JOIN Shift_Relation ON Shift.shift_id=Shift_Relation.shift_id WHERE shift_type_id=@shift_type_id", conn);
                cmd.Parameters.AddWithValue("@shift_type_id", type);
                SqlDataReader reader = cmd.ExecuteReader();
                ShiftDTO shift = new ShiftDTO();

                while (reader.Read())
                {

                    shift.ShiftID = reader.GetInt32("shift_id");
                    shift.Date = DateOnly.FromDateTime(reader.GetDateTime("date"));
                    shift.ShiftType = reader.GetInt32("shift_type_id");
                    shift.EmployeeId = reader.GetInt32("employee_id");
                    
                }
                return shift;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public ShiftDTO GetShiftEmployeeByDate(DateOnly date)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT shift_id, shift_type_id, Shift_Relation.employee_id FROM Shift JOIN Shift_Relation ON Shift.shift_id=Shift_Relation.shift_id WHERE date=@date", conn);
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataReader reader = cmd.ExecuteReader();
                ShiftDTO shift = new ShiftDTO();

                while (reader.Read())
                {
                    shift.ShiftID = reader.GetInt32("shift_id");
                    shift.Date = DateOnly.FromDateTime(reader.GetDateTime("date"));
                    shift.ShiftType = reader.GetInt32("shift_type_id");
                    shift.EmployeeId = reader.GetInt32("employee_id");
                    
                }
                return shift;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<ShiftDTO> GetAllShifts()
        {

            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Shift.shift_id, Shift.date, Shift.shift_type_id, Shift.numberofemployees, Shift_Relation.employee_id FROM Shift JOIN Shift_Relation ON Shift.shift_id=Shift_Relation.shift_id  ", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                
                List<ShiftDTO> shifts = new List<ShiftDTO>();
                while (reader.Read())
                {
                    ShiftDTO shift = new ShiftDTO();
                    shift.ShiftID = reader.GetInt32("shift_id");
                    shift.Date = DateOnly.FromDateTime(reader.GetDateTime("date"));
                    shift.ShiftType = reader.GetInt32("shift_type_id");
                    shift.EmployeeId = reader.GetInt32("employee_id");
                    shift.numEmpl = reader.GetInt32("numberofemployees");
                    shifts.Add(shift);
                }
                return shifts;

            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public bool AddEmployeeToShift(int shiftId, int employeeId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "INSERT INTO Shift_Relation(shift_id,employee_id) VALUES (@shift_id,@employee_id)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@shift_id", shiftId);
                command.Parameters.AddWithValue("@employee_id", employeeId);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected == 1;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    return false;
                }
            }
        }

        public bool CheckEmployeeOnShift(DateOnly date, int type, int employeeid)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Shift JOIN Shift_Relation ON Shift.shift_id=Shift_Relation.shift_id WHERE date=@date AND shift_type_id=@shift_type_id AND employee_id = @employee_id", conn);

                DateTime Date = new DateTime(date.Year, date.Month, date.Day);
                cmd.Parameters.AddWithValue("@date", Date);
                cmd.Parameters.AddWithValue("@shift_type_id", type);
                cmd.Parameters.AddWithValue("@employee_id", employeeid);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                
                if (reader.Read())
                {
                    return true;
                }
                else
                return false;


            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SetPreferedScheduleForUser(int idUser, string day, int type, DateTime selectedDate)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [Prefered Schedule] WHERE [employee_id] = @UserId AND date_monday=@date_monday", conn);
                checkCommand.Parameters.AddWithValue("@UserId", idUser);
                checkCommand.Parameters.AddWithValue("@date_monday", selectedDate.Date);
                int count = (int)checkCommand.ExecuteScalar();

                SqlCommand cmd;

                if (count > 0)
                {
                    cmd = new SqlCommand($"UPDATE [Prefered Schedule] SET [{day.ToLower()}] =@Type WHERE [employee_id] = @UserId AND date_monday=@date_monday AND date_tuesday=@date_tuesday AND date_wednesday=@date_wednesday AND date_thursday=@date_thursday AND date_friday=@date_friday AND date_saturday=@date_saturday AND date_sunday=@date_sunday", conn);
                }
                else
                {
                    cmd = new SqlCommand($"INSERT INTO [Prefered Schedule] ([employee_id], [{day.ToLower()}], date_monday, date_tuesday, date_wednesday, date_thursday, date_friday, date_saturday, date_sunday) VALUES (@UserId, @Type, @date_monday, @date_tuesday, @date_wednesday, @date_thursday, @date_friday, @date_saturday, @date_sunday)", conn);
                }
                
                cmd.Parameters.AddWithValue("@UserId", idUser);
                if (type == -1)
                {
                    cmd.Parameters.AddWithValue("@Type", -1);
                }
                else
                {
                    if (type == 0) cmd.Parameters.AddWithValue("@Type", type);
                    else cmd.Parameters.AddWithValue("@Type", type );
                }
                
                cmd.Parameters.AddWithValue("@date_monday", selectedDate.Date);
                cmd.Parameters.AddWithValue("@date_tuesday", selectedDate.AddDays(1).Date);
                cmd.Parameters.AddWithValue("@date_wednesday", selectedDate.AddDays(2).Date);
                cmd.Parameters.AddWithValue("@date_thursday", selectedDate.AddDays(3).Date);
                cmd.Parameters.AddWithValue("@date_friday", selectedDate.AddDays(4).Date);
                cmd.Parameters.AddWithValue("@date_saturday", selectedDate.AddDays(5).Date);
                cmd.Parameters.AddWithValue("@date_sunday", selectedDate.AddDays(6).Date);
                cmd.ExecuteNonQuery();

                return true;


            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int? GetPreferedScheduleForUser(int idUser, string day, DateTime selectedDate)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                List<int?> schedule = new List<int?>();
                conn.Open();
                SqlCommand checkCommand = new SqlCommand("SELECT [" + day + "] FROM [Prefered Schedule] WHERE [employee_id] = @UserId AND date_monday = @date_monday", conn);
                checkCommand.Parameters.AddWithValue("@UserId", idUser);
                checkCommand.Parameters.AddWithValue("@date_monday", selectedDate.Date);

                SqlDataReader reader = checkCommand.ExecuteReader();

                if (reader.Read())
                {
                    int columnIndex = reader.GetOrdinal(day);
                    if (reader.GetInt32(columnIndex) != -1 && reader.GetInt32(columnIndex) != 0)
                    {
                        int value = reader.GetInt32(columnIndex);
                        return value ;
                    }
                    else
                    {
                        if (reader.GetInt32(columnIndex) == 0)
                        {
                            return reader.GetInt32(columnIndex);
                        }
                        else
                        {
                            return null;
                        }

                    }
                    
                    
                }
                return null;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool DeletePreferedScheduleForUser(int idUser, DateTime selectedDate)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                List<int?> schedule = new List<int?>();
                conn.Open();
                SqlCommand checkCommand = new SqlCommand("DELETE FROM [Prefered Schedule] WHERE [employee_id] = @UserId AND date_monday = @date_monday", conn);
                checkCommand.Parameters.AddWithValue("@UserId", idUser);
                checkCommand.Parameters.AddWithValue("@date_monday", selectedDate.Date);
                checkCommand.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CheckEmployeeOnDate(DateOnly date, int employeeid)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Shift JOIN Shift_Relation ON Shift.shift_id=Shift_Relation.shift_id WHERE date=@date AND employee_id = @employee_id", conn);

                DateTime Date = new DateTime(date.Year, date.Month, date.Day);
                cmd.Parameters.AddWithValue("@date", Date);
                cmd.Parameters.AddWithValue("@employee_id", employeeid);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read())
                {
                    return true;
                }
                else
                    return false;


            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<(DateTime date, int shiftType)> GetPreferedScheduleByUserId(int id, DateTime startDate, DateTime endDate)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                startDate = startDate.Date;
                endDate= endDate.Date;
                List<(DateTime date, int shiftType)> values = new List<(DateTime date, int shiftType)>();
                conn.Open();
                SqlCommand checkCommand = new("select Distinct p2.* from [Prefered Schedule] as p1 join [Prefered Schedule] as p2 on p2.employee_id=p1.employee_id WHERE p1.employee_id=@employee_id  and  (p1.[date_monday]>=@start_date or p2.[date_monday]<=@end_date)", conn);
                checkCommand.Parameters.AddWithValue("@employee_id", id);
                checkCommand.Parameters.AddWithValue("@start_date", startDate);
                checkCommand.Parameters.AddWithValue("@end_date", endDate);

                SqlDataReader reader = checkCommand.ExecuteReader();

                while (reader.Read())
                {
                    DateTime mondayDate = reader.GetDateTime("date_monday");
                    DateTime tuesdayDate = reader.GetDateTime("date_tuesday");
                    DateTime wednesdayDate = reader.GetDateTime("date_wednesday");
                    DateTime thursdayDate = reader.GetDateTime("date_thursday");
                    DateTime fridayDate = reader.GetDateTime("date_friday");
                    DateTime saturdayDate = reader.GetDateTime("date_saturday");
                    DateTime sundayDate = reader.GetDateTime("date_sunday");
                    if(mondayDate>=startDate && mondayDate<=endDate)
                    {
                        
                        int mondayShiftType = (int)reader["monday"];
                        values.Add((mondayDate, mondayShiftType));
                    }
                    if (tuesdayDate >= startDate && tuesdayDate <= endDate)
                    {
                        int tuesdayShiftType = (int)reader["tuesday"];
                        values.Add((tuesdayDate, tuesdayShiftType));
                    }
                    if (wednesdayDate >= startDate && wednesdayDate <= endDate)
                    {
                        int wednesdayShiftType = (int)reader["wednesday"];
                        values.Add((wednesdayDate, wednesdayShiftType));
                    }
                    if (thursdayDate >= startDate && thursdayDate <= endDate)
                    {
                        int thursdayShiftType = (int)reader["thursday"];
                        values.Add((thursdayDate, thursdayShiftType));
                    }
                    if (fridayDate >= startDate && fridayDate <= endDate)
                    {
                        int fridayShiftType = (int)reader["friday"];
                        values.Add((fridayDate, fridayShiftType));
                    }
                    if (saturdayDate >= startDate && saturdayDate <= endDate)
                    {
                        int  saturdayShiftType = (int   )reader["saturday"];
                        values.Add((saturdayDate, saturdayShiftType));
                    }
                    if (sundayDate >= startDate && sundayDate <= endDate)
                    {
                        int sundayShiftType = (int)reader["sunday"];
                        values.Add((sundayDate, sundayShiftType));
                    } 
                }
                return values;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<(DateTime date, ShiftType shiftType)> GetFreeSpotsBetweenStartAndEnd(DateTime startDate, DateTime endDate)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                startDate = startDate.Date;
                endDate = endDate.Date;
                List<(DateTime date, ShiftType shiftType)> values = new List<(DateTime date, ShiftType shiftType)>();
                conn.Open();
                SqlCommand checkCommand = new SqlCommand("SELECT s.[date], s.[shift_type_id], s.[numberofemployees], " +
                                         "(SELECT COUNT(sr.[employee_id]) FROM [Shift_Relation] sr WHERE sr.[shift_id] = s.[shift_id]) AS numEmployeesAssigned " +
                                         "FROM [Shift] s " +
                                         "WHERE s.[date] >= @start_date AND s.[date] <= @end_date", conn);
                checkCommand.Parameters.AddWithValue("@start_date", startDate);
                checkCommand.Parameters.AddWithValue("@end_date", endDate);

                SqlDataReader reader = checkCommand.ExecuteReader();

                while (reader.Read())
                {
                    DateTime date = (DateTime)reader["date"];
                    ShiftType shiftType = (ShiftType)reader["shift_type_id"];
                    int numberOfEmployees = (int)reader["numberofemployees"];
                    int numEmployeesAssigned = (int)reader["numEmployeesAssigned"];

                    int numFreeSpots = numberOfEmployees - numEmployeesAssigned;
                    if (numFreeSpots > 0)
                    {
                        for (int i = 0; i < numFreeSpots; i++)
                        {
                            values.Add((date, shiftType));
                        }
                    }
                }
                return values;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool CreateShiftForGenerater(DateOnly date, int type, int numEmpl)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    

                        SqlCommand cmd = new SqlCommand("INSERT INTO [Shift] (date, shift_type_id, numberofemployees) VALUES (@date, @shift_type_id, @numberofemployees)", conn);
                        DateTime Date = new DateTime(date.Year, date.Month, date.Day);
                        cmd.Parameters.AddWithValue("@date", Date);
                        cmd.Parameters.AddWithValue("@shift_type_id", type);
                        cmd.Parameters.AddWithValue("@numberofemployees", numEmpl);
                        cmd.ExecuteNonQuery();

                        return true;
                }
                catch
                {
                    return false;
                }

            }
        }
    }
}

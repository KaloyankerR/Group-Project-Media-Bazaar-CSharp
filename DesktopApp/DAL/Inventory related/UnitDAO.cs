using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Inventory_related;

namespace DAL.Inventory_related
{
    public class UnitDAO : Repository, IUnitDAO
    {
        public bool CreateUnit(Unit unit)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                using SqlCommand cmd = new SqlCommand("INSERT INTO Unit(unit_name) VALUES (@unit_name)", conn);
                cmd.Parameters.AddWithValue("@unit_name", unit.name);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
           
        }

        public bool DeleteUnit(Unit unit)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                using SqlCommand cmd = new SqlCommand("DELETE FROM Unit WHERE unit_id=@unit_id", conn);
                cmd.Parameters.AddWithValue("@unit_id",unit.unitID);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Unit> GetAllUnits()
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                using SqlCommand cmd = new SqlCommand("SELECT * FROM Unit", conn);
                List<Unit> units = new List<Unit>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    Unit unit = new Unit();
                    unit.unitID = reader.GetInt32("unit_id");
                    unit.name = reader.GetString("unit_name");
                    units.Add(unit);
                }
                return units;
            }
            catch(SqlException ex) 
            {
                return null;
            }
        }

        public Unit GetUnitById(int id)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                using SqlCommand cmd = new SqlCommand("SELECT * FROM Unit WHERE unit_id=@unit_id", conn);
                cmd.Parameters.AddWithValue("@unit_id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                Unit unit = new();
                if(reader.Read())
                {
                    unit.unitID = reader.GetInt32("unit_id");
                    unit.name = reader.GetString("unit_name");
                }
                return unit;
            }
            catch (SqlException ex)
            {
                return null;
            }
        }

        public bool UpdateUnit(Unit unit)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                using SqlCommand cmd = new SqlCommand("UPDATE Unit SET unit_name=@unit_name WHERE unit_id=@id", conn);
                cmd.Parameters.AddWithValue("@unit_name", unit.name);
                cmd.Parameters.AddWithValue("@id",unit.unitID);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }
    }
}

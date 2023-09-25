using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Classes;
using Classes.Request_related;

namespace DAL.Request_related
{
    public class RequestDAO : Repository, IRequestDAO
    {
        public bool CreateRequest(Request request)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Request(department_id,date) VALUES(@department_id,@date)", conn);
                DateTime date = new DateTime(request.date.Year, request.date.Month, request.date.Day);
                cmd.Parameters.AddWithValue("@department_id", request.department.DepartmentId);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddItemToRequestByRequestId(int request_id,int product_id,int quantity,string status,string message) 
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Requested-items](request_id,product_id,quantity,status,message) VALUES(@request_id,@product_id,@quantity,@status,@message)", conn);
                cmd.Parameters.AddWithValue("@request_id", request_id);
                cmd.Parameters.AddWithValue("@product_id", product_id);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@status", status);
                if(message==null) cmd.Parameters.AddWithValue("@message", string.Empty);
                else cmd.Parameters.AddWithValue("@message", message);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteRequest(Request request,int product_id,string message)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [Requested-items] SET status=@status,message=@message WHERE request_id=@request_id AND product_id=@product_id", conn);
                cmd.Parameters.AddWithValue("@request_id", request.request_id);
                cmd.Parameters.AddWithValue("@status", "Declined");
                cmd.Parameters.AddWithValue("@product_id", product_id);
                cmd.Parameters.AddWithValue("@message", message);
                cmd.ExecuteNonQuery();


                SqlCommand cmd1 = new SqlCommand("DELETE FROM [Requested-items] WHERE request_id=@request_id AND product_id=@product_id", conn);
                cmd1.Parameters.AddWithValue("@request_id", request.request_id);
                cmd1.Parameters.AddWithValue("@product_id", product_id);
                cmd1.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ProductDTO> GetAllProductsByRequestId(int id)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                List<ProductDTO> products = new List<ProductDTO>();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Requested-items] AS r JOIN Product AS p ON r.product_id=p.product_id  WHERE request_id=@request_id ", conn);
                cmd.Parameters.AddWithValue("@request_id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    ProductDTO product = new ProductDTO();
                    product.ProductID = reader.GetInt32("product_id");
                    product.ProductName = reader.GetString("product_name");
                    product.ProductPrice = reader.GetDouble("price");
                    product.ProductQuantity = reader.GetInt32("quantity");
                    if (reader.GetInt32("iteam_threshold") == null)
                    {
                        product.IteamThreshold = 0;
                    }
                    else
                    {
                        product.IteamThreshold = reader.GetInt32("iteam_threshold");
                    }

                    product.SubCategory = reader.GetInt32("category_id");
                    product.Unit = reader.GetInt32("product_unit");
                    product.Department = reader.GetInt32("department_id");
                    products.Add(product);
                }
                return products;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<RequestDTO> GetAllRequests()
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                List<RequestDTO>requests = new List<RequestDTO>();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT r.request_id AS 'Id', r.department_id AS 'DeptId', r.date AS 'Date', ri.status AS 'Status', ri.message AS 'Message', ri.quantity AS 'Quantity', p.product_name AS 'Product' FROM [Requested-items] AS ri INNER JOIN Request AS r ON ri.request_id = r.request_id INNER JOIN Product as p ON p.product_id = ri.product_id", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    RequestDTO request = new();
                    request.request_id = reader.GetInt32("Id");
                    request.department = reader.GetInt32("DeptId");
                    request.status = reader.GetString("Status");
                    request.date = DateOnly.FromDateTime(reader.GetDateTime("Date"));
                    request.message = reader.GetString("Message");
                    request.quantity = reader.GetInt32("Quantity");
                    request.product = reader.GetString("Product");
                    requests.Add(request);
                }
                return requests;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public RequestDTO GetRequestById(int id)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                RequestDTO request = new RequestDTO();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Request WHERE request_id=@request_id", conn);
                cmd.Parameters.AddWithValue("@request_id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    
                    request.request_id = reader.GetInt32("request_id");
                    request.department = reader.GetInt32("department_id");
                    //request.status = reader.GetString("status");
                    request.date = DateOnly.FromDateTime(reader.GetDateTime("date"));
                }
                return request;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public RequestDTO GetLastRequestByDepartmentId(Department department)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                RequestDTO request = new RequestDTO();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Request WHERE request_id=(SELECT MAX(request_id)  FROM Request)", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    request.request_id = reader.GetInt32("request_id");
                    request.department = reader.GetInt32("department_id");
                    request.date = DateOnly.FromDateTime(reader.GetDateTime("date"));
                }
                return request;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public bool UpdateRequest(Request request,Product product,string message)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [Requested-items] SET status=@status,message=@message WHERE request_id=@request_id AND product_id=@product_id", conn);
                cmd.Parameters.AddWithValue("@status", request.status);
                cmd.Parameters.AddWithValue("@request_id", request.request_id);
                cmd.Parameters.AddWithValue("@product_id", product.ProductID);
                cmd.Parameters.AddWithValue("@message", message);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public int GetQuantityByRequestAndProdactId(int requestId, int productId)
        {
            
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                int quantity;
                RequestDTO request = new RequestDTO();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT quantity FROM [Requested-items] WHERE product_id=@product_id AND request_id=@request_id", conn);
                cmd.Parameters.AddWithValue("@product_id", productId);
                cmd.Parameters.AddWithValue("@request_id", requestId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    quantity = reader.GetInt32("quantity");
                    return quantity;
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool CkeckIfThereIsRequestWithTheSameProductAndDateInTheSameRequest(int request_id,int product_id,DateOnly date)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                DateTime Date = new DateTime(date.Year,date.Month,date.Day);
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Requested-items] WHERE  product_id=@product_iD AND request_id=@request_id", conn);
                cmd.Parameters.AddWithValue("@product_id", product_id);
                cmd.Parameters.AddWithValue("@request_id", request_id);
                //cmd.Parameters.AddWithValue("date", Date);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { return true; }
                else return false;
            }
            catch (Exception) 
            {
                return  false;
            }
        }

        public bool AddQunatityIfThereIsRequestWithTheSameProductAndDateInTheSameRequest(int request_id, int product_id, DateOnly date,int quantity)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                DateTime Date = new DateTime(date.Year, date.Month, date.Day);
                SqlCommand cmd = new SqlCommand("UPDATE [Requested-items] SET quantity = @quantity WHERE request_id = @request_id AND product_id = @product_id ", conn);
                cmd.Parameters.AddWithValue("@product_id", product_id);
                cmd.Parameters.AddWithValue("@request_id", request_id);
                //cmd.Parameters.AddWithValue("date", Date);
                cmd.Parameters.AddWithValue("@quantity",quantity);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<RequestDTO> GetAllRequestedItem()
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                List<RequestDTO> requests = new List<RequestDTO>();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT r.request_id,r.department_id,ri.product_id,ri.quantity,ri.[status],r.date,ri.message FROM [Requested-items] AS ri JOIN Request as r ON ri.request_id=r.request_id ", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    RequestDTO request = new();
                    request.request_id = reader.GetInt32("request_id");
                    request.department = reader.GetInt32("department_id");
                    request.status= reader.GetString("status");
                    request.date = DateOnly.FromDateTime(reader.GetDateTime("date"));
                    request.message=reader.GetString("message");
                    requests.Add(request);
                }
                return requests;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetPendingRequests()
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT r.request_id,d.[name],p.product_name,ri.quantity,ri.[status],r.date FROM [Requested-items] AS ri JOIN Request as r ON ri.request_id=r.request_id JOIN Product AS p ON p.product_id=ri.product_id JOIN Department AS d ON d.department_id=r.department_id WHERE ri.status='Pending'", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Clear();
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("Department", typeof(string));
                    //dt.Columns.Add("Status", typeof(string));
                    dt.Columns.Add("Product", typeof(string));
                    dt.Columns.Add("Quantity", typeof(int));
                    dt.Columns.Add("Date", typeof(DateOnly));
                    while (reader.Read())
                    {
                        DataRow row = dt.NewRow();
                        row["ID"] = reader.GetInt32("request_id");
                        row["Department"] = reader.GetString("name");
                        row["Product"] = reader.GetString("product_name");
                        row["Quantity"] = reader.GetInt32("quantity");
                        row["Date"] = DateOnly.FromDateTime(reader.GetDateTime("date"));
                        dt.Rows.Add(row);
                    }
                    return dt;
                }
                catch (SqlException ex)
                {
                    return null;
                }
            }
        }
        public DataTable GetAllRequestInDataTable() 
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT r.request_id,d.[name],p.product_name,ri.quantity,r.date ,ri.[status],ri.message FROM [Requested-items] AS ri JOIN Request as r ON ri.request_id=r.request_id JOIN Product AS p ON p.product_id=ri.product_id JOIN Department AS d ON d.department_id=r.department_id", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Clear();
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("Department", typeof(string));
                    dt.Columns.Add("Product", typeof(string));
                    dt.Columns.Add("Quantity", typeof(int));
                    dt.Columns.Add("Date", typeof(DateOnly));
                    dt.Columns.Add("Status", typeof(string));
                    dt.Columns.Add("Message", typeof(string));
                    while (reader.Read())
                    {
                        DataRow row = dt.NewRow();
                        row["ID"] = reader.GetInt32("request_id");
                        row["Department"] = reader.GetString("name");
                        row["Product"] = reader.GetString("product_name");
                        row["Quantity"] = reader.GetInt32("quantity");
                        row["Date"] = DateOnly.FromDateTime(reader.GetDateTime("date"));
                        row["Status"] = reader.GetString("status");
                        row["Message"]=reader.GetString("message");
                        dt.Rows.Add(row);
                    }
                    return dt;
                }
                catch (SqlException ex)
                {
                    return null;
                }
            }
        }
        public DataTable GetAllResponseInDataTableByDepartmentId(int id) 
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT r.request_id, d.[name],p.product_name,ri.quantity,r.date ,ri.[status],ri.message FROM[Requested-items] AS ri JOIN Request as r ON ri.request_id=r.request_id JOIN Product AS p ON p.product_id=ri.product_id JOIN Department AS d ON d.department_id=r.department_id Where d.department_id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Clear();
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("Department", typeof(string));
                    dt.Columns.Add("Product", typeof(string));
                    dt.Columns.Add("Quantity", typeof(int));
                    dt.Columns.Add("Date", typeof(DateOnly));
                    dt.Columns.Add("Status", typeof(string));
                    dt.Columns.Add("Message", typeof(string));
                    while (reader.Read())
                    {
                        DataRow row = dt.NewRow();
                        row["ID"] = reader.GetInt32("request_id");
                        row["Department"] = reader.GetString("name");
                        row["Product"] = reader.GetString("product_name");
                        row["Quantity"] = reader.GetInt32("quantity");
                        row["Date"] = DateOnly.FromDateTime(reader.GetDateTime("date"));
                        row["Status"] = reader.GetString("status");
                        row["Message"] = reader.GetString("message");
                        dt.Rows.Add(row);
                    }
                    return dt;
                }
                catch (SqlException ex)
                {
                    return null;
                }
            }
        }
    }
}

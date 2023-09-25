using Classes;
using Classes.Inventory_related;
using Classes.Request_related;
using DAL;
using DAL.Inventory_related;
using DAL.Request_related;
using LL.Inventory_related;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL.Request_Related
{
    public class RequestManager:IRequestManager
    {
        IRequestDAO requestDAO;
        public RequestManager(IRequestDAO requestDAO) 
        { 
            this.requestDAO = requestDAO;
        }

        public bool CreateRequest(Request request)
        {
            try
            {
                if (requestDAO.CreateRequest(request))
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

        public bool DeleteRequest(Request request, int id, string message)
        {
            try
            {
                if (requestDAO.DeleteRequest(request,id,message))
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
        public bool UpdateRequest(Request request, Product product, string message)
        {
            try
            {
                if (requestDAO.UpdateRequest(request,product, message))
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

        public List<Product> GetAllProductsByRequestId(int id)
        {
            DepartmentManager departmentManager = new(new DepartmentDAO());
            CategoryManager categoryManager = new(new CategoryDAO());
            UnitManager unitManager = new(new UnitDAO());
            Product product;
            List<Product> products = new List<Product>();
            foreach (ProductDTO productDTO in requestDAO.GetAllProductsByRequestId(id))
            {
                Department? department = departmentManager.GetDepartmentById(productDTO.Department);
                Category category = categoryManager.GetCategoryByID(productDTO.SubCategory);
                Unit unit = unitManager.GetUnitById(productDTO.Unit);
                product = new Product(productDTO.ProductID, productDTO.ProductName, productDTO.ProductPrice, productDTO.ProductQuantity, unit, category, department);
                products.Add(product);
            }
            return products;
        }

        public List<Request> GetAllRequests()
        {
            Request request;
            DepartmentManager departmentManager = new(new DepartmentDAO());
            List < Request > requests = new List < Request >();
            foreach (RequestDTO requestDTO in requestDAO.GetAllRequests())
            {
                Department department = departmentManager.GetDepartmentById(requestDTO.department);
                request = new Request(requestDTO.request_id, department, requestDTO.status, requestDTO.date, requestDTO.product, requestDTO.quantity, requestDTO.message);
                requests.Add(request);
            }
            return requests;
        }

        public Request GetRequestById(int id)
        {
            Request request;
            DepartmentManager departmentManager = new(new DepartmentDAO());
            RequestDTO requestDTO = requestDAO.GetRequestById(id);
            Department department = departmentManager.GetDepartmentById(requestDTO.department);
            request = new Request(requestDTO.request_id, department, requestDTO.status, requestDTO.date);            
            return request;
        }

        public bool AddItemToRequestByRequestId(int request_id, int product_id, int quantity, string status, string message)
        {
            try
            {
                if(requestDAO.AddItemToRequestByRequestId(request_id, product_id, quantity,status,message))
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Request GetLastRequestByDepartmentId(Department department)
        {
            Request request;
            DepartmentManager departmentManager = new(new DepartmentDAO());
            RequestDTO requestDTO = requestDAO.GetLastRequestByDepartmentId(department);
            Department department1 = departmentManager.GetDepartmentById(requestDTO.department);
            request = new Request(requestDTO.request_id, department1, requestDTO.status, requestDTO.date,requestDTO.message);
            return request;
        }

        public int GetQuantityByRequestAndProdactId(int requestId, int productId)
        {
            int quantity=requestDAO.GetQuantityByRequestAndProdactId(requestId, productId);
            return quantity;
        }

        public bool CkeckIfThereIsRequestWithTheSameProductAndDateInTheSameRequest(int request_id, int product_id, DateOnly date)
        {
            return requestDAO.CkeckIfThereIsRequestWithTheSameProductAndDateInTheSameRequest(request_id, product_id, date);
        }

        public bool AddQunatityIfThereIsRequestWithTheSameProductAndDateInTheSameRequest(int request_id, int product_id, DateOnly date, int quantity)
        {
            return requestDAO.AddQunatityIfThereIsRequestWithTheSameProductAndDateInTheSameRequest(request_id,product_id,date,quantity);
        }
        public List<Request> GetAllRequestedItem()
        {
            Request request;
            DepartmentManager departmentManager = new(new DepartmentDAO());
            List<Request> requests = new List<Request>();
            foreach (RequestDTO requestDTO in requestDAO.GetAllRequestedItem())
            {
                Department department = departmentManager.GetDepartmentById(requestDTO.department);
                request = new Request(requestDTO.request_id, department, requestDTO.status, requestDTO.date,requestDTO.message);
                requests.Add(request);
            }
            return requests;
        }
        public DataTable GetPendingRequests()
        {
            return requestDAO.GetPendingRequests();
        }

        public DataTable GetAllRequestInDataTable()
        {
            return requestDAO.GetAllRequestInDataTable();
        }

        public DataTable GetAllResponseInDataTableByDepartmentId(int id)
        {
            return requestDAO.GetAllResponseInDataTableByDepartmentId(id);
        }
    }
}

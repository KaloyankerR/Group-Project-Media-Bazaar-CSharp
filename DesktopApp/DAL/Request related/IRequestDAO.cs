using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using Classes.Request_related;

namespace DAL.Request_related
{
    public interface IRequestDAO
    {
        bool CreateRequest(Request request);
        public bool AddItemToRequestByRequestId(int request_id, int product_id, int quantity, string status, string message);
        bool UpdateRequest(Request request,Product product, string message);
        bool DeleteRequest(Request request, int id, string message);
        RequestDTO GetRequestById(int id);
        RequestDTO GetLastRequestByDepartmentId(Department department);
        List<RequestDTO> GetAllRequests();
        List<ProductDTO> GetAllProductsByRequestId(int id);
        int GetQuantityByRequestAndProdactId(int requestId, int productId);
        public bool CkeckIfThereIsRequestWithTheSameProductAndDateInTheSameRequest(int request_id, int product_id, DateOnly date);
        public bool AddQunatityIfThereIsRequestWithTheSameProductAndDateInTheSameRequest(int request_id, int product_id, DateOnly date, int quantity);
        public List<RequestDTO> GetAllRequestedItem();
        public DataTable GetPendingRequests();
        public DataTable GetAllRequestInDataTable();
        public DataTable GetAllResponseInDataTableByDepartmentId(int id);
    }
}

using Classes;
using Classes.Request_related;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL.Request_Related
{
    public interface IRequestManager
    {
        bool CreateRequest(Request request);
        bool DeleteRequest(Request request, int id, string message);
        bool UpdateRequest(Request request, Product product, string message);
        public bool AddItemToRequestByRequestId(int request_id, int product_id, int quantity, string status, string message);
        Request GetRequestById(int id);
        Request GetLastRequestByDepartmentId(Department department);
        List<Request> GetAllRequests();
        List<Product> GetAllProductsByRequestId(int id);
        int GetQuantityByRequestAndProdactId(int requestId, int productId);

        public bool CkeckIfThereIsRequestWithTheSameProductAndDateInTheSameRequest(int request_id, int product_id, DateOnly date);
        public bool AddQunatityIfThereIsRequestWithTheSameProductAndDateInTheSameRequest(int request_id, int product_id, DateOnly date, int quantity);
        public List<Request> GetAllRequestedItem();
        public DataTable GetPendingRequests();
        public DataTable GetAllRequestInDataTable();
        public DataTable GetAllResponseInDataTableByDepartmentId(int id);
    }
}

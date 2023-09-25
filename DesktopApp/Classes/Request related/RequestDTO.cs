using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Request_related
{
    public class RequestDTO
    {
        public int request_id;
        public int department;
        public string status;
        public DateOnly date;
        public string message;
		public int quantity;
        public string product;
		public RequestDTO() { }

        public RequestDTO(int request_id, int department, string status, DateOnly date)
        {
            this.request_id = request_id;
            this.department = department;
            this.status = status;
            this.date = date;
            
        }
        public RequestDTO(int request_id, int department, string status, DateOnly date, string message)
        {
            this.request_id = request_id;
            this.department = department;
            this.status = status;
            this.date = date;
            this.message = message;
        }
        public RequestDTO (int request_id, int department, string status, DateOnly date, int quantity, string message)
        {
            this.request_id = request_id;
            this.department = department;
            this.status = status;
            this.date = date;
            this.quantity = quantity;
            this.message = message;
        }
    }
}

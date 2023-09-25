using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Request_related
{
    public class Request
    {
        public int request_id;
        public Department department;
        public string status;
        public DateOnly date;
        public string message;
        public int quantity;
        public string product;
        public Request() { }

        public Request(int request_id, Department department, string status, DateOnly date)
        {
            this.request_id = request_id;
            this.department = department;
            this.status = status;
            this.date = date;
            
        }
        public Request(int request_id, Department department, string status, DateOnly date, string message)
        {
            this.request_id = request_id;
            this.department = department;
            this.status = status;
            this.date = date;
            this.message = message;
        }
		public Request(int request_id, Department department, string status, DateOnly date, string product, int quantity, string message)
		{
			this.request_id = request_id;
			this.department = department;
			this.status = status;
			this.date = date;
            this.product = product;
			this.quantity = quantity;
			this.message = message;
		}
	}
}

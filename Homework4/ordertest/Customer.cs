using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest
{
    class Customer {
        private uint customerId;
        private string customerName;

        public Customer(uint id, string name) {
            CustomerId = id;
            CustomerName = name;
        }

        public uint CustomerId {
            get { return customerId; }
            set { customerId = value; }
        }

        public string CustomerName {
            get { return customerName; } 
            set { customerName = value; }
        }

        public string Info {
            get { return $"customerId:{customerId}, CustomerName:{CustomerName}"; }
        }
    }
}

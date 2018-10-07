using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {

    class Order {

        private uint orderId;

        private Customer customer;

        private Dictionary<uint, OrderDetails> orderDetailsDict;

        public Order(uint orderId, Customer customer) {
            OrderId = orderId;
            Customer = customer;
            orderDetailsDict = new Dictionary<uint, OrderDetails>();
        }

        public uint OrderId {
            get { return orderId; } 
            set { orderId = value; }
        }

        public Customer Customer {
            get { return customer; }
            set { customer = value; }
        }

        // add new orderDetails to order
        public void AddOrderDetails(OrderDetails orderDetails) {
            if (orderDetailsDict.ContainsKey(orderDetails.OrderDetailsId))  {
                throw new Exception($"orderDetails-{orderDetails.OrderDetailsId} is already existed!");
            } else {
                orderDetailsDict[orderDetails.OrderDetailsId] = orderDetails;
            }
        }

        // remove orderDetails by orderDetailsId
        public void RemoveOrderDetails(uint orderDetailsId) {
            if (orderDetailsDict.ContainsKey(orderDetailsId)) {
                orderDetailsDict.Remove(orderDetailsId);
            } else {
                throw new Exception($"orderDetails-{orderDetailsId} is not existed!");
            }
        }

        // get all orderDetails in this order
        public List<OrderDetails> GetAllOrderDetails() {
            return orderDetailsDict.Values.ToList();
        }
        
        public string Info {
            get {
                string result = "================================================================================\n";
                result += $"orderId:{orderId}\tcustomer:({customer.Info})";
                foreach(OrderDetails od in orderDetailsDict.Values.ToList()) {
                    result += "\n    " + od.Info;
                }
                result += "\n================================================================================";
                return result;
            }
        }
    }
}

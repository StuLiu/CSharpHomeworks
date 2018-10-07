using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {

    class OrderService {
        //实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询)

        private Dictionary<uint, Order> orderDict;

        public OrderService() {
            orderDict = new Dictionary<uint, Order>();
        }

        // add new order
        public void AddOrder(Order order) {
            if (orderDict.ContainsKey(order.OrderId)) {
                throw new Exception($"order-{order.OrderId} is already existed!");
            } else {
                orderDict[order.OrderId] = order;
            }
        }

        // cancel order
        public void RemoveOrder(uint orderId) {
            if (orderDict.ContainsKey(orderId)) {
                orderDict.Remove(orderId);
            } else {
                throw new Exception($"order-{orderId} is not existed!");
            }
        }

        // query all orders
        public List<Order> GetAllOrders() {
            return orderDict.Values.ToList();
        }

        // query by orderId
        public List<Order> GetOrderById(uint orderId) {
            List<Order> result = new List<Order>();
            if (orderDict.ContainsKey(orderId)){
                result.Add(orderDict[orderId]);
            }
            return result;
        }

        // query by goodsName
        public List<Order> GetOrdersByGoodsName(string goodsName) {
            List<Order> result = new List<Order>();
            foreach (Order order in orderDict.Values.ToList()) {
                List<OrderDetails> orderDetailsList = order.GetAllOrderDetails();
                foreach(OrderDetails od in orderDetailsList) {
                    if(od.Goods.Name == goodsName) {
                        result.Add(order);
                        break;
                    }
                }
            }
            return result;
        }

        // query by customerName
        public List<Order> GetOrdersByCustomerName(string customerName) {
            List<Order> result = new List<Order>();
            foreach (Order order in orderDict.Values.ToList()) {
                if(order.Customer.CustomerName == customerName) {
                    result.Add(order);
                }
            }
            return result;
        }

        // edit order's customer
        public void EditOrderCustomer(uint orderId, Customer newCustomer) {
            if (orderDict.ContainsKey(orderId)) {
                orderDict[orderId].Customer = newCustomer;
            } else {
                throw new Exception($"order-{orderId} is not existed!");
            }
        }

        /*other edit function with write in the future.*/
    }
}

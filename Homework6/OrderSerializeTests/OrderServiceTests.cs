﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ordertest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest.Tests {
    [TestClass()]
    public class OrderServiceTests {

        private Customer customer1, customer2;
        private Goods milk, egg, apple;
        private OrderDetail orderDetails1, orderDetails2, orderDetails3;
        private Order order1, order2, order3;

        private void init() {
            customer1 = new Customer(1, "liuwang");
            customer2 = new Customer(2, "jams");

            apple = new Goods(3, "apple", 5.59);
            egg = new Goods(2, "egg", 4.99);
            milk = new Goods(1, "milk", 69.9);

            orderDetails1 = new OrderDetail(1, apple, 8);
            orderDetails2 = new OrderDetail(2, egg, 2);
            orderDetails3 = new OrderDetail(3, milk, 1);

            order1 = new Order(1, customer1);
            order2 = new Order(2, customer2);
            order3 = new Order(3, customer2);

            order1.AddOrderDetail(orderDetails1);
            order1.AddOrderDetail(orderDetails2);
            order1.AddOrderDetail(orderDetails3);
            order2.AddOrderDetail(orderDetails2);
            order2.AddOrderDetail(orderDetails3);
            order3.AddOrderDetail(orderDetails3);
        }

        [TestMethod()]
        public void AddOrderTest() {
            init();
            OrderService os = new OrderService();
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            Assert.AreEqual(os.Orders.Count, 3);
            try {
                os.AddOrder(order3);
            } catch(Exception e) {
                Assert.AreEqual(e.Message, "Order is already existed!");
            }
        }

        [TestMethod()]
        public void RemoveOrderTest() {
            init();
            OrderService os = new OrderService();
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            os.RemoveOrder(3);
            Assert.AreEqual(os.Orders.Count, 2);
            os.RemoveOrder(100);
            Assert.AreEqual(os.Orders.Count, 2);
        }

        [TestMethod()]
        public void QueryOrderByIdTest() {
            init();
            OrderService os = new OrderService();
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            Assert.AreEqual(os.QueryOrderById(2).Count, 1);
            Assert.AreEqual(os.QueryOrderById(3)[0].OrderId, (uint)3);
            Assert.AreEqual(os.QueryOrderById(100).Count, 0);
        }

        [TestMethod()]
        public void QueryOrdersByGoodsNameTest() {
            init();
            OrderService os = new OrderService();
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            Assert.AreEqual(os.QueryOrdersByGoodsName("apple").Count, 1);
            Assert.AreEqual(os.QueryOrdersByGoodsName("egg").Count, 2);
            Assert.AreEqual(os.QueryOrdersByGoodsName("milk").Count, 3);
            Assert.AreEqual(os.QueryOrdersByGoodsName("orange").Count, 0);
        }

        [TestMethod()]
        public void QueryOrdersByCustomerNameTest() {
            init();
            OrderService os = new OrderService();
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            Assert.AreEqual(os.QueryOrdersByCustomerName("liuwang").Count, 1);
            Assert.AreEqual(os.QueryOrdersByCustomerName("jams").Count, 2);
            Assert.AreEqual(os.QueryOrdersByCustomerName("Lysa").Count, 0);
        }

        [TestMethod()]
        public void UpdateOrderCustomerTest() {
            init();
            OrderService os = new OrderService();
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            os.UpdateOrderCustomer(2, customer1);
            Assert.AreEqual(os.QueryOrdersByCustomerName("liuwang").Count, 2);
            try {
                os.UpdateOrderCustomer(100, customer1);
            } catch (Exception e) {
                Assert.AreEqual(e.Message, "Order is not existed!");
            }
        }

        [TestMethod()]
        public void ExportTest() {
            init();
            OrderService os = new OrderService();
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            os.Export();
        }

        [TestMethod()]
        public void ImportTest() {
            init();
            OrderService os = new OrderService();
            os.Import("./orders.xml");
            Assert.AreEqual(os.Orders.Count, 3);
            try {
                os.Import("./orders3.xml");
            }
            catch (Exception e) {
                Assert.IsInstanceOfType(e, typeof(FileNotFoundException));
            }
        }
    }
}
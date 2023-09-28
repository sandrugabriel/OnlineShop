﻿using OnlineShop.Models;
using OnlineShop.Orders.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestServices
{
    public class TestOrderQueryService
    {

        private IOrderQueryService _orderQueryService;

        [Fact]
        public void Test_When_IsTrue()
        {
            List<int> list = new List<int>() { 12, 13, 4, 2, 3 };
            Order order1 = new Order(1, 150, list, 1);
            Order order2 = new Order(2, 150, list, 1);
            Order order3 = new Order(3, 170, list, 1);
            Order order4 = new Order(4, 180, list, 1);
            List<Order> orders = new List<Order>() { order1, order2, order3, order4 };

            _orderQueryService = new OrderQueryService(orders);

            Assert.Equal(order1,_orderQueryService.getById(1));

        } 

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Models;
using OnlineShop.OrdersDetails.Service;
using OnlineShop.OrdersDetails.Service.interfaces;

namespace TestServices
{
    public class TestOrdersDetails
    {

        private IOrderDetailsComandService _orderdetails;

        string path = @"OrdersDetails\Data\ordersDetalis.txt";

        [Fact]
        public void OrderDetails_When_Istrue()
        {

            List<int> list = new List<int>() { 12, 13, 4, 2, 3 };
            List<int> list1 = new List<int>() { 1, 3, 4, 2, 3 };

            OrderDetalis orderDetalis = new OrderDetalis(1, 2, "Str.asd", DateTime.Now, list, list1);
            OrderDetalis orderDetalis1 = new OrderDetalis(1, 2, "Str.asd", DateTime.Now, list, list1);
            List<OrderDetalis> orders = new List<OrderDetalis> { orderDetalis,orderDetalis1 };
            _orderdetails = new OrderDetailsComandService(orders);

            Assert.Equal(path,_orderdetails.Path());

        }

        private IOrderDetailsQueryService _orderdetailsQueryService;

        [Fact]
        public void QueryDetails_When_Istrue()
        {

            List<int> list = new List<int>() { 12, 13, 4, 2, 3 };
            List<int> list1 = new List<int>() { 1, 3, 4, 2, 3 };

            OrderDetalis orderDetalis = new OrderDetalis(1, 2, "Str.asd", DateTime.Now, list, list1);
            OrderDetalis orderDetalis1 = new OrderDetalis(5, 2, "Str.asd", DateTime.Now, list, list1);
            List<OrderDetalis> orders = new List<OrderDetalis> { orderDetalis, orderDetalis1 };
            _orderdetailsQueryService = new OrderDetailsQueryServicecs(orders);

            Assert.Equal(orderDetalis, _orderdetailsQueryService.getById(1));

        }

    }
}

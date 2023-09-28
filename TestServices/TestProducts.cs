using OnlineShop.Models;
using OnlineShop.Products;
using OnlineShop.Products.Service;
using OnlineShop.Products.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestServices
{
    public class TestProducts
    {

        private IProductComandService _productService;

        string path = @"Users\Data\users.txt";

        [Fact]
        public void Comand_When_Istrue()
        {
            List<int> list = new List<int>() { 1, 2, 34 };
            Product product = new Product(1, "Asd", 23, 5, "...", list);
            Product product1 = new Product(5, "Asd", 23, 5, "...", list);

            List<Product> products = new List<Product>() { product,product1 };

            _productService = new ProductComandService(products);

            Assert.Equal(path, _productService.Path());

        }

        private IProductQueryService _queryService;

        [Fact]
        public void Query_When_Istrue()
        {
            List<int> list = new List<int>() { 1, 2, 34 };
            Product product = new Product(1, "Asd", 23, 5, "...", list);
            Product product1 = new Product(5, "Asd", 23, 5, "...", list);

            List<Product> products = new List<Product>() { product, product1 };

            _queryService = new ProductQueryService(products);

            Assert.Equal(product, _queryService.getByID(1));


        }

    }
}

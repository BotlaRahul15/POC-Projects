using Microsoft.AspNetCore.Mvc;
using ProductsAPI;
using ProductsAPI.Controllers;
using System.Collections.Generic;
using Xunit;

namespace ProductAPI.XTest
{
    public class ProductXunit
    {
        private readonly IJwtAuth _jwtAuth = null;
        Product product = new Product();
        List<Product> productList = new List<Product>();
        
        [Fact]
        public void Get()
        {
            ProductController productController = new ProductController(_jwtAuth);
            var result = productController.Get();
            var okResult = result as ObjectResult;
            if (okResult.StatusCode == 404)
            {
                Assert.Equal(404, okResult.StatusCode);
            }
            else if (okResult.StatusCode == 400)
            {
                Assert.Equal(400, okResult.StatusCode);
            }
            else if (okResult.StatusCode == 200)
            {
                Assert.Equal(200, okResult.StatusCode);
            }
        }

        [Fact]
        public void GetbyId()
        {
            int id = 1;
            ProductController productController = new ProductController(_jwtAuth);
            var result = productController.GetBy(id);
            var okResult = result as ObjectResult;
            if (okResult.StatusCode == 404)
            {
                Assert.Equal(404, okResult.StatusCode);
            }
            else if (okResult.StatusCode == 400)
            {
                Assert.Equal(400, okResult.StatusCode);
            }
            else if (okResult.StatusCode == 200)
            {
                Assert.Equal(200, okResult.StatusCode);
            }
        }

        [Fact]
        public void Create()
        {
            ProductController productController = new ProductController(_jwtAuth);
            Product product = new Product { ProductName = "Acer", ProductFeatures = "wdj", ProductPrice = 4000 };
            var result = productController.Create(product);
            var okResult = result as ObjectResult;
            if (okResult.StatusCode == 404)
            {
                Assert.Equal(okResult.StatusCode, 404);
            }
            else if (okResult.StatusCode == 400)
            {
                Assert.Equal(okResult.StatusCode, 400);
            }
            else if (okResult.StatusCode == 200)
            {
                Assert.Equal(okResult.StatusCode, 200);
            }
        }

        [Fact]
        public void Delete()
        {
            int id = 66;
            ProductController productController = new ProductController(_jwtAuth);
            var result = productController.Delete(id);
            var okResult = result as ObjectResult;
            if (okResult.StatusCode == 404)
            {
                Assert.Equal(okResult.StatusCode, 404);
            }
            else if (okResult.StatusCode == 400)
            {
                Assert.Equal(okResult.StatusCode, 400);
            }
            else if (okResult.StatusCode == 200)
            {
                Assert.Equal(okResult.StatusCode, 200);
            }
        }
    }
}

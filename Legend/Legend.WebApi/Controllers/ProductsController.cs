using Legend.WebApi.Models;

using System;
using System.Collections.Generic;
using System.Linq;

using System.Web.Http;

namespace WebApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 2 },
            new Product { Id = 2, Name = "Teddy Bear", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Laptop", Category = "Hardware", Price = 999.9M }
        };

        // GET api/Products
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/Products/1
        public IHttpActionResult Get(int id)
        {
            var product = products.Where(p => p.Id == id).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopAPI.Models;

namespace ShopAPI.Controllers
{
    [Route("api/Products")]
    [ApiController]
    public class ProductsController : Controller
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Mouse", Category = "PC", Price = 29.99M },
            new Product { Id = 2, Name = "Haworthia Fasciata", Category = "Plants and succulents", Price = 15.00M },
            new Product { Id = 3, Name = "'How to win friends and influence people' - Dale Carnegie", Category = "Books", Price = 20.99M }
        };

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return products;
        }


    }
}
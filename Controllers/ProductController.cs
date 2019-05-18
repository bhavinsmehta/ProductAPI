using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;

namespace ProductAPI.Controllers
{
    [Route("api/Product")] 
    [ApiController]
   public class ProductController:ControllerBase
   {
       // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get() 
        { return new List<Product>{
        new Product {
            ProductId = 1,
            ProductName = "Id1",
            ProductDescription = "Desc 1"
        },
        new Product {
            ProductId = 2,
            ProductName = "Id2",
            ProductDescription = "Desc 2"
        }};
        }
        // GET api/values
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id) {
       return new Product {
            ProductId = 1,
            ProductName = "Id1",
            ProductDescription = "Desc 1"};
        }


   }
}
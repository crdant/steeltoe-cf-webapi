using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

using core_cf_webapi.Models;

namespace core_cf_webapi.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IConfigurationRoot _config;

        public ProductsController(IConfigurationRoot config)
        {
            _config = config;
        }

        // GET api/products
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            Console.WriteLine($"connection string is {_config["productdbconnstring"]}");
            Console.WriteLine($"Log level from config is {_config["loglevel"]}");
            return new[] {
                new Product ( 1120, "Patio Set", "https://contentgrid.homedepot-static.com/hdus/en_US/DTCCOMNEW/fetch/Category_Pages/Outdoor/Patio_Furniture/L2-conversation-sets.jpg" ),
                new Product ( 1020, "Weber Grill", "https://cdn.instructables.com/FPI/MX26/IRXTUTHU/FPIMX26IRXTUTHU.LARGE.jpg")
            };
        }
    }
}
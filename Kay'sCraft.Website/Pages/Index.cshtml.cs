using KaysCraft.Website.Models;
using KaysCraft.Website.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kay_sCraft.Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        //Declaring the Product Service
        public JsonFileProductService ProductService;
        //Declring an IEnumerable Collection of Products 
        public IEnumerable<Product> Products { get; private set; }


        public IndexModel(ILogger<IndexModel> logger, JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}

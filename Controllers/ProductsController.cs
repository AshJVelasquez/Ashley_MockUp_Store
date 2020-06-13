using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Printful_Library.Services;

namespace Ashley_MockUp_Store.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IPrintfulServices _printfulServices;
        public ProductsController (IPrintfulServices printfulServices)
        {
            _printfulServices = printfulServices;
        }

        //TODO set the route to get the id and accept what the result is
        [HttpGet]
        [Route("product/{id}")]
        public async Task<IActionResult> ProductPage(int id)
        {
            var result = await _printfulServices.GetAllProductInfo(id);
            var total = result.Result;
            return View(total);
        }
    }
}
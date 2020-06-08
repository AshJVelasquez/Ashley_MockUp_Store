using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ashley_MockUp_Store.Models;
using Microsoft.AspNetCore.Authorization;
using javax.naming.directory;
using System.Net.Http;
using Printful_Library.Services;
using Printful_Library.Models;

namespace Ashley_MockUp_Store.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly IPrintfulServices _printfulService;

        public HomeController(IPrintfulServices printfulService)
        {
            _printfulService = printfulService;
        }


        public async Task<IActionResult> Index()
        {
            var result = await _printfulService.GetFullInventory();
            var total = result.Result.ToList();
            //TODO 06-03-2020 Then insert into method to get all data in one place
            //List<Product> = FrontPageViewModel.ReturnProductList(total);
            return View(total);
        }
    }
}

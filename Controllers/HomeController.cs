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
using org.omg.PortableServer;

namespace Ashley_MockUp_Store.Controllers
{
    
    public class HomeController : Controller
    {
        private IPrintfulServices _printfulServices;
        public HomeController (IPrintfulServices printfulServices)
        {
            _printfulServices = printfulServices;
        }
        //private IFrontPageViewModel _frontPageViewModel;

        //public HomeController(IFrontPageViewModel frontPageViewModel)
        //{
        //    _frontPageViewModel = frontPageViewModel;
        //}


        public async Task<IActionResult> Index()
        {
            var list= await _printfulServices.GetFullInventory();
            var total = list.Result.ToList();

            return View(total);
        }
    }
}

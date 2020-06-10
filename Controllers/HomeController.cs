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
        private readonly IFrontPageViewModel _frontPageView;

        public HomeController(IFrontPageViewModel frontPageView)
        {
            _frontPageView = frontPageView;
        }
       

        public Task<IActionResult> Index()
        {
            var total =  _frontPageView.GetProductList();
            //var productList = result.Result.ToList();
            //var total = .ReturnProductList(productList).ToList();
            //TODO 06-03-2020 Then insert into method to get all data in one place
            //List<Product> = FrontPageViewModel.ReturnProductList(total);
            return View(total);
        }
    }
}

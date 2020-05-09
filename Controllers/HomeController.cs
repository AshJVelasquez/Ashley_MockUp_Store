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

namespace Ashley_MockUp_Store.Controllers
{
    
    public class HomeController : Controller
    {
        // Begin 
        // 05-09-2020 : 20486D - Developing ASP.NET Core MVC Web Applications - Module 13 Implementing Web APIs - Lesson 3
        private IHttpClientFactory _httpClientFactory;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        //End

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpClient httpClient = _httpClientFactory.CreateClient(); //05-09-2020 Added this line
            return View();
        }

        //BEGIN 
        //05-09-2020 Added this section to set up for api controller 
        //No idea if this will work. I think throwing stuff together might help. Haha, but I think at my next time, I will watch a video on how to do this process cause so far the book is not making sense. 
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("api/[controller]")]
        [ApiController]
        public class ValuesController : ControllerBase
        {
            Dictionary<string, string> _items = new Dictionary<string, string>();

            public ValuesController()
            {
                _items["key1"] = "value1";
                _items["key2"] = "value2";
            }

            [HttpGet("{id}")]
            public ActionResult<string> Get(string id)
            {
                if (_items.ContainsKey(id) == false)
                    return NotFound();

                return _items[id];
            }
        }
        //END
    }
}

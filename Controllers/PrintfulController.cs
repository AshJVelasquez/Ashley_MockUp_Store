using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Printful_Library.Services;

namespace Ashley_MockUp_Store.Controllers
{
    public class PrintfulController : Controller
    {
        private readonly IPrintfulServices _printfulService;

        public PrintfulController(IPrintfulServices printfulService)
        {
            _printfulService = printfulService;
        }

        [HttpGet]
        [Route ("v1/printful/inventory")]
        public async Task<IActionResult> GetInventory()
        {
            var result = await _printfulService.GetFullInvenotry();
            return Ok(result);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ashley_MockUp_Store.Models;
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
        [Route("printful/inventory")]
        public async Task<IActionResult> GetInventory()
        {
            var result = await _printfulService.GetFullInventory();
            var total = result.Result.ToList();
            return Ok(total);
        }


        //TODO Determine if this brings up what I need
        [HttpGet]
        [Route("printful/inventory/{id}")]
        public async Task<IActionResult> GetProductInfo(int id)
        {
            var result = await _printfulService.GetAllProductInfo(id);
            var total = result.Result.ToList();
            return Ok(total);
        }
    }
}
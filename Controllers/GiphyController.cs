using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Giphy_Lib.Services;
using Microsoft.AspNetCore.Mvc;


namespace Ashley_MockUp_Store.Controllers
{
    public class GiphyController : Controller
    {
        private readonly IGiphyServices _giphyService; //05-11-2020 Now we go back up here and initialize service as our constructor

        public GiphyController(IGiphyServices giphyService)
        {
            _giphyService = giphyService;
        }

        //05-12-2020 Adding the route so we show what we want to show to the end user
        [HttpGet]
        [Route ("v1/giphy/random/[searchCriteria]")]
        public async Task<IActionResult> GetRandomGif(string searchCriteria)
        {
            var result = await _giphyService.GetRandomGifBasedOnSearchCritera(searchCriteria); 
            
            //05-11-2020 YT Daniel mentions that the _giphyServices typed out here are understood as wishful programming (which is where we write code AS IF we already created them. So the red squiggly just means that is what we will call the service, not that it already exists! Seen this before in my class. Nice to have a name for it (real or not!)

            return Ok(result);
        }
    }
}
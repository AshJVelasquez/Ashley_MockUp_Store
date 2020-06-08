using Printful_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ashley_MockUp_Store.Models
{
    public interface IFrontPageViewModel
    {
        //TODO 06-03-2020 Do I still need this? Clarification, do I still need this interface when I have a separate products list? 
        public List<Product> products{ get; set; }
        public List<Product> ReturnProductList(List<SyncProduct> total);
    }
}

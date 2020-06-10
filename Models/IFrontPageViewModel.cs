using Printful_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ashley_MockUp_Store.Models
{
    public interface IFrontPageViewModel
    {
        public List<Product> CreateProductListToDisplay();
        public List<Product> products { get; set; }
        public List<SyncProduct> list { get; set; }
    }
}

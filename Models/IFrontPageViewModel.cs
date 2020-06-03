using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ashley_MockUp_Store.Models
{
    public interface IFrontPageViewModel
    {
        //TODO 06-03-2020 Do I still need this?
        public List<Product> products{ get; set; }
    }
}

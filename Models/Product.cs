using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ashley_MockUp_Store.Models
{
    public class Product
    {

        public int ID { get; set; }
        public string ExternalID { get; set; }
        public string Name { get; set; }
        public int Variants { get; set; }
        public string ThumbnailUrl { get; set; }

        //05-17-2020 Commenting these out for later
        //public string TypeName { get; set; }
        //public string Currency { get; set; }
        //public bool IsDiscontinued { get; set; }
        //public float AvgTimeFilled { get; set; }


    }
}

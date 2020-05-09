using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ashley_MockUp_Store.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string TypeName { get; set; }
        public string Currency { get; set; }
        public bool IsDiscontinued { get; set; }
        public float AvgTimeFilled { get; set; }


    }
}

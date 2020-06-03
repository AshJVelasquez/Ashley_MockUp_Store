using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Printful_Library.Models;

namespace Ashley_MockUp_Store.Models
{
    public static class FrontPageViewModel
    {
        public static List<Product> ReturnProductList(List<SyncProduct> total)
        {
            List<Product> products = new List<Product>();
            
            foreach(SyncProduct product in total)
            {
                Product item = new Product() 
                { 
                    ID = product.id, 
                    ImageURL = product.thumbnail_url, 
                    Name = product.name 
                };
                item.Price = GetProductPrice();
                item.NumberOfSizes = GetProductSizes();
            }
            return products;
        }
        //TODO Method on getting Price
        //06-03-2020 Let's get by with STARTING PRICE AT $$$$
        public static float GetProductPrice()
        {
            throw new NotImplementedException();
        }
        //TODO Method on getting Sizes
        public static int GetProductSizes()
        {
            throw new NotImplementedException();
        }
    }
}

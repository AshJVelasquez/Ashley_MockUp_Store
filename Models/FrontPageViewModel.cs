using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Printful_Library.Models;
using Printful_Library.Printful;

namespace Ashley_MockUp_Store.Models
{
    public class FrontPageViewModel
    {
        public List<Product> ReturnProductList(List<SyncProduct> total)
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
                //item.Price = GetProductPrice(item.ID);
                //item.NumberOfSizes = GetProductSizes();
                //TODO 06-07-2020 Finish this wishful programming
                ProductTotalInfo details = ReturnProductDetails(product.id);
                item.Price = GetProductPrice(details);
                item.NumberOfSizes = GetProductSizes(details);
            }
            return products;
        }

        //TODO 06-07-2020 Returning only the class
        public ProductTotalInfo ReturnProductDetails(int id)
        {
            throw new NotImplementedException();
        }

        //TODO 06/07/2020 How do I get all the product info? 
        public async Task<ProductTotalInfo> GetProductDetails(int id)
        {
            throw new NotImplementedException();
        }

        //TODO Method on getting Price
        //06-03-2020 Let's get by with STARTING PRICE AT $$$$
        public float GetProductPrice(ProductTotalInfo details)
        {
            throw new NotImplementedException();
        }
        //TODO Method on getting Sizes
        public int GetProductSizes(ProductTotalInfo details)
        {
            throw new NotImplementedException();
        }
    }
}

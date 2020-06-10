using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Printful_Library.Models;
using Printful_Library.Printful;
using Printful_Library.Services;

namespace Ashley_MockUp_Store.Models
{
    public class FrontPageViewModel
    {
        private readonly IPrintfulServices _printfulServices;
        public FrontPageViewModel(IPrintfulServices printfulServices)
        {
            _printfulServices = printfulServices;
        }

        public List<SyncProduct> list;

        public async void GetProductList() 
        {
            var syncProducts = await _printfulServices.GetFullInventory();
            list = syncProducts.Result.ToList();
        } 
        public void GetPrice() 
        { 
            
        } // Here I get the price
        public void CreateProductListToDisplay() { } // then I want to create the list of products 


        //    public async IAsyncEnumerable<SyncProduct> ReturnProductList()
        //    {
        //        var result = await _printfulServices.GetFullInventory();
        //        var total = result.Result;
        //        return total;
        //    }

        //        List<Product> products = new List<Product>();

        //        foreach(SyncProduct product in total)
        //        {
        //            Product item = new Product() 
        //            { 
        //                ID = product.id, 
        //                ImageURL = product.thumbnail_url, 
        //                Name = product.name 
        //            };
        //            //item.Price = GetProductPrice(item.ID);
        //            //item.NumberOfSizes = GetProductSizes();
        //            //TODO 06-07-2020 Finish this wishful programming
        //            var details = await _printfulServices.GetAllProductInfo(product.id);
        //            item.Price = GetProductPrice(details);
        //            //item.NumberOfSizes = GetProductSizes(details); I want to test the price first
        //        }
        //        return products.;
        //    }

        //    public ProductTotalInfo ReturnProductDetails(int id)
        //    {
        //        var result = GetProductDetails(id);
        //        var details = result.Result;
        //        return details;
        //    }

        //    public async Task<ProductTotalInfo> GetProductDetails(int id)
        //    {
        //        var result = await ReturnProductInfo(id);
        //        return result;
        //    }

        //    public float GetProductPrice(ProductTotalInfo details)
        //    {
        //        //TODO 06-08-2020 Write conditions incase this cannot be retrived
        //        //Also, I may need to add CultureInfo according to StackOverflow
        //        var value = float.Parse(details.Result.SyncVariants[0].price);
        //        return value;
        //    }

        //    public int GetProductSizes(ProductTotalInfo details)
        //    {
        //        throw new NotImplementedException();
        //    }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Printful_Library.Models;
using Printful_Library.Printful;
using Printful_Library.Services;

namespace Ashley_MockUp_Store.Models
{
    //TODO 06-13-2020 Work on this code later to be able to display the price on the same page

    public class FrontPageViewModel : IFrontPageViewModel
    {
        public List<SyncProduct> list;
        public List<Product> products;
        public float tempPrice;

        private readonly IPrintfulServices _printfulServices;

        public FrontPageViewModel(IPrintfulServices printfulServices)
        {
            _printfulServices = printfulServices;
        }

        

        public async void GetProductList() 
        {
            list = new List<SyncProduct>();
            var syncProducts = await _printfulServices.GetFullInventory();
            list = syncProducts.Result.ToList();
        }

        public List<Product> CreateProductListToDisplay() 
        {
            products = new List<Product>();
            GetProductList();

            foreach(SyncProduct syncProduct in list)
            {
                Product product = new Product
                {
                    ID = syncProduct.id,
                    Name = syncProduct.name,
                    ImageURL = syncProduct.thumbnail_url
                };
                GetPrice(product.ID);
                product.Price = tempPrice;
                products.Add(product);
            }
            return products;
        } 

        public async void GetPrice(int id) 
        {
            var details = await _printfulServices.GetAllProductInfo(id);
            tempPrice = float.Parse(details.Result.SyncVariants[0].price);
        } 



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

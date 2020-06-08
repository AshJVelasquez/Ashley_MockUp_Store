using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ashley_MockUp_Store.Models
{
    public class Product
    {

        private string productName;
        private int productID;
        private float productPrice;
        private string productImage;
        //private int colorsAvaliable;
        private int productSizes;

        public string Name
        {
            get { return productName; }
            set { productName = value; }
        }
        public int ID
        {
            get { return productID; }
            set { productID = value; }
        }
        public float Price
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        public string ImageURL
        {
            get { return productImage; }
            set { productImage = value; }
        }
        public int NumberOfSizes
        {
            get { return productSizes; }
            set { productSizes = value; }
        }
    }
}

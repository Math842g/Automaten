using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Product
    {
        #region Fields
        //Creating fields.
        private string productName;
        private int productId;
        private int price;
        private int stock;
        #endregion
        #region Propeties
        //Creating getters and setters.
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion
        #region Constructors
        //Creating constructors.
        public Product()
        {

        }
        public Product(string _productName, int _price, int _stock, int _productId)
        {
            ProductName = _productName;
            Price = _price;
            Stock = _stock;
            ProductId = _productId;
        }
        #endregion
    }
}

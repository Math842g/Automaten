using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Automat
    {
        #region List
        //Creating products list.
        private List<Product> products = new List<Product>();
        #endregion
        #region getters
        //Creating a get for the products list.
        public List<Product> Products
        {
            get { return products; }
        }
        #endregion
        #region methods
        public void AddProductToList(Product p)
        {
            //Adds the product from the method parameter to the products list.
            products.Add(p);
        }
        #endregion
    }
}

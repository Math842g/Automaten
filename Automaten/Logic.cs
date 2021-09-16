using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Logic
    {
        #region Fields
        //Creating objects-
        Automat automat = new Automat();
        Money money = new Money();
        #endregion
        #region Methods

        public void AddProducts()
        {
            //Creating products for the list in the Automat class.
            Product cola = new Product("Coca Cola", 10, 2, 1);
            Product faxeKondi = new Product("Faxe Kondi", 10, 2, 2);
            Product fanta = new Product("Fanta", 15, 3, 3);
            Product pepsi = new Product("Pepsi", 10, 1, 4);
            Product sprite = new Product("Sprite", 20, 1, 5);
            //Sending the products to the AddProductToList method in the Automat class.
            automat.AddProductToList(cola);
            automat.AddProductToList(faxeKondi);
            automat.AddProductToList(fanta);
            automat.AddProductToList(pepsi);
            automat.AddProductToList(sprite);
        }
        public Automat GetProducts()
        {
            //Returns the automat object.
            return automat;
        }
        public bool AddMoney(string _coin)
        {
            //Creating a bool to determine if the coin is valid.
            bool coinExist = true;
            //Compares the users input to the valid coins, and if the user input is right, then adds the coin to the balance.
            if (_coin.ToLower() == "1")
            {
                money.CurrentBalance += money.One;
            }
            else if (_coin == "2")
            {
                money.CurrentBalance += money.Two;
            }
            else if (_coin == "5")
            {
                money.CurrentBalance+= money.Five;
            }
            else if (_coin == "10")
            {
                money.CurrentBalance+= money.Ten;
            }
            else if (_coin == "20")
            {
                money.CurrentBalance+= money.Twenty;
            }
            //If the user input is not a valid coin, then sets coinExist to false and returns it.
            else
            {
                coinExist = false;
            }
            return coinExist;
        }
        public string BuyProduct(int _choice)
        {
            //Creating a string to return text.
            string returnText = "";
            //using a foreach loop to go through each object in the list.
            foreach (Product product in automat.Products)
            {
                //Makes sure edit the object, the user chose
                if(product.ProductId == _choice)
                {
                    // Checks if the product has 1 or more in stock, and the balance is over or equal to the product price.
                    //If these conditions are true, then removes 1 from stock and updates the current balance, and returns a status message.
                    if (product.Stock >= 1 && money.CurrentBalance >= product.Price)
                    {
                        product.Stock -= 1;
                        money.CurrentBalance -= product.Price;
                        Console.ForegroundColor = ConsoleColor.Green;
                        returnText += $"You succesfully purchased a {product.ProductName}, remember to pick it up";
                    }
                    //If the product is out of stock, then returns a sold out message.
                    else if(product.Stock == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        returnText += $"{product.ProductName} is sold out";
                    }
                    //If none of these above conditions are true, then we know there isnt enough balance, and returns a not enough balance message.
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        returnText += "You dont have enough balance";
                    }
                }
            }
            //Return the text from one of the above conditions.
            return returnText;
        }
        public int WithdrawMoney()
        {
            //Creates a variable with the amount of money to withdraw.
            int withdrawedMoney = money.CurrentBalance;
            //Calcuate and sets the new balance, which should be 0.
            money.CurrentBalance -= money.CurrentBalance;
            //Returns the amount of withdrawed money.
            return withdrawedMoney;
        }
        public void RefillProducts()
        {

        }
        public string RemoveMoney()
        {

        }
        public void AdjustPrices(int _choice, int _newPrice)
        {
            //Loops through all products in products list
            foreach (Product product in automat.Products)
            {
                //Makes sure edit the object, the user chose
                if (product.ProductId == _choice)
                {
                    product.Price = _newPrice;
                }
            }
        }
        #endregion
    }
}

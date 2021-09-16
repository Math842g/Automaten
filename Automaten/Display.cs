using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Automaten
{
    class Display
    {
        static void Main(string[] args)
        {
            //Instantiating object.
            Display display = new Display();
            //Running DisplayMenu method.
            display.DisplayMenu();
        }
        #region Fields
        Logic logic = new Logic();
        Money money = new Money();
        #endregion
        #region Methods
        public void DisplayLogo()
        {
            //Changing text color to blue.
            Console.ForegroundColor = ConsoleColor.Blue;
            //writing the logo.
            Console.WriteLine(@" ________  __                                              __                                          __     
/        |/  |                                            /  |                                        /  |
$$$$$$$$/ $$ | ____    ______          ______   __    __  _$$ | _     ______   _____  ____    ______   _$$ | _   
   $$ |   $$      \  /      \        /      \ /  |  /  |/ $$   |   /      \ /     \/    \  /      \ / $$   |
   $$ |   $$$$$$$  |/$$$$$$  |       $$$$$$  |$$ |  $$ |$$$$$$/   /$$$$$$  |$$$$$$ $$$$  | $$$$$$  |$$$$$$/
   $$ |   $$ |  $$ |$$    $$ |       /    $$ |$$ |  $$ |  $$ | __ $$ |  $$ |$$ | $$ | $$ | /    $$ |  $$ | __ 
   $$ |   $$ |  $$ |$$$$$$$$/       /$$$$$$$ |$$ \__$$ |  $$ |/  |$$ \__$$ |$$ | $$ | $$ |/$$$$$$$ |  $$ |/  |
   $$ |   $$ |  $$ |$$       |      $$    $$ |$$    $$/   $$  $$/ $$    $$/ $$ | $$ | $$ |$$    $$ |  $$  $$/ 
   $$/    $$/   $$/  $$$$$$$/        $$$$$$$/  $$$$$$/     $$$$/   $$$$$$/  $$/  $$/  $$/  $$$$$$$/    $$$$/  
                                                                               ");
        }
        public void DisplayMenu()
        {
            //Creating the variable choice.
            int choice;
            //Running AddProducts method.
            logic.AddProducts();

            //Starts the loop, and repeating it while choice is not 7.
            do
            {
                //Setting choice to 0 at the beginning of every loop, so it doesnt repeat the same function as last time if you just hit enter.
                choice = 0;
                //Displays logo in the console.
                this.DisplayLogo();
                //writes the current balance, and inserts a money menu for the user.
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Current balance: {money.CurrentBalance} kr\n8. Insert balance\n9. Withdraw money");
                //Shows available products.
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAvailable products:");

                foreach (Product product in logic.GetProducts().Products)
                {
                    Console.WriteLine($"\n{product.ProductId}. {product.ProductName}\tPrice: {product.Price}\tStock: {product.Stock}");
                }
                //Last part of the menu.
                Console.Write("\n6. Admin menu\n7. Exit\nMake your choice:");

                //Catches if the user inserts anything else than a number.
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have to insert a number");
                }
                //Picking a case depending on what the user inputs.
                switch (choice)
                {
                    //Case 1-5 runs the BuyProduct method, which returns a string with the status.
                    case 1:
                        Console.WriteLine(logic.BuyProduct(choice));
                        break;
                    case 2:
                        Console.WriteLine(logic.BuyProduct(choice));
                        break;
                    case 3:
                        Console.WriteLine(logic.BuyProduct(choice));
                        break;
                    case 4:
                        Console.WriteLine(logic.BuyProduct(choice));
                        break;
                    case 5:
                        Console.WriteLine(logic.BuyProduct(choice));
                        break;
                    case 6:
                        //Runs the DisplayAdminMenu
                        this.DisplayAdminMenu();
                        break;
                    case 7:
                        //Exits loop.
                        break;
                    case 8:
                        //Runs the DisplayMoneyMenu method.
                        this.DisplayMoneyMenu();
                        break;
                    case 9:
                        //Runs the WithdrawMoney method, which returns a string with the amount of money withdrawed.
                        Console.WriteLine($"{logic.WithdrawMoney()} kr. has been withdrawed");
                        break;
                    default:
                        Console.WriteLine("Please insert a number between 1-9");
                        break;
                }
                //Makes the user press any key to continue.
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                //clears the console
                Console.Clear();
                //Countinues the loop if the user didnt insert 7.
            } while (choice != 7);
        }
        public void DisplayMoneyMenu()
        {
            //Telling the user to insert a coin.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Insert a coin e.g. 1, 2, 5, 10, 20");
            //Creating a string which contains the inserted coin.
            string insertedCoin = Console.ReadLine();
            //Runs the AddMoney method, which returns true if the coin is recognized, and prints out a succesfull message.
            if (logic.AddMoney(insertedCoin) == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{insertedCoin} kr. has succesfully been added to your balance");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            //If coin is not recognized an error message will be printed out.
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Could not regognize coin, please try again");
            }
        }
        public void DisplayAdminMenu()
        {
            int passwordGuesses = 0;
            bool exitMenu = false;
            do
            {
                Console.Clear();
                Console.Write("Password: ");
                string insertedPassword = Console.ReadLine();
                if (insertedPassword == "Automat")
                {
                    Console.Clear();
                    Console.WriteLine($"1. Refill Products\n2. Remove money\n3. Adjust prices");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            this.DisplayRefillMenu();
                            exitMenu = true;
                            break;
                        case 2:
                            Console.WriteLine(logic.RemoveMoney();
                            exitMenu = true;
                            break;
                        case 3:
                            this.DisplayPriceMenu();
                            exitMenu = true;
                            break;
                    }
                }
                else
                {
                    passwordGuesses += 1;
                    Console.WriteLine($"Wrong password, you have {3 - passwordGuesses} guesses left");
                }
                Thread.Sleep(1500);
                if(passwordGuesses == 3)
                {
                    break;
                }

            } while (exitMenu != true);
            
        }
        public void DisplayPriceMenu()
        {
            Console.Clear();

            foreach (Product product in logic.GetProducts().Products)
            {
                Console.WriteLine($"\n{product.ProductId}. {product.ProductName}\tPrice: {product.Price}");
            }
            Console.Write("Enter the id of the product you want to change the price on: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("Enter new price:");
            int newPrice = int.Parse(Console.ReadLine());
            logic.AdjustPrices(choice, newPrice);
            Console.WriteLine("Price updated, returning to the main menu");
            Thread.Sleep(3000);
        }
        public void DisplayRefillMenu()
        {

        }
        #endregion
    }
}

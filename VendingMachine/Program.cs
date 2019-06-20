using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine {
    class Program {

        static List<Item> items = new List<Item>();
        static void Main(string[] args) {
            float budget = getBudget();
            string input = "";

            while(input.ToLower() != "e") {
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("Would you like to: ");
                Console.WriteLine("(A)dd and item");
                Console.WriteLine("(C)heck budget");
                Console.WriteLine("(E)xit");
                Console.Write("Enter selection: ");

                input = Console.ReadLine();

                if(input.ToLower() == "a") {
                    addItem();
                } else if(input.ToLower() == "c") {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine();
                    //------- Add Code to calculate if items exceed the budget ----//
                    //------- Example below gets everything from items and prints name and price ----/
                    foreach (Item i in items) {
                        Console.WriteLine(i.Name + "  $" + i.Price);
                    }


                    // Print message indicating current budget and whether items exceed budget or not
                }
            }
            

            

        }

        static float getBudget() {
            string input = "";
            float price = -1f;

            Console.Write("Please enter budget: $");
            input = Console.ReadLine();
            price = float.Parse(input);
        
            return price;
        }

        static void addItem() {
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            string input = "";
            string name;
            float price = -1f;
            string itemType = "";

            Console.Write("Enter Item name: ");
            name = Console.ReadLine();
        
            Console.Write("Enter Item price: ");
            input = Console.ReadLine();
            price = float.Parse(input);

            //------------- Edit from this point to implement Clothing --------//
            // Get Item type
            Console.Write("Enter Item type (F)ood ");
            itemType = Console.ReadLine();
            
            // Get data for food - this may be of use as an example
            if(itemType.ToLower() == "f") {
                int grossWeight = -1;

                Console.Write("Enter Gross Weight: ");
                input = Console.ReadLine();
                grossWeight = int.Parse(input);

                Food newFood = new Food(name, price, grossWeight);
                items.Add(newFood);  
            }


            // ---------------------------------------------------------------//
           
        }


        
    }

   
}

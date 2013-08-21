using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3
{
    class ProductPricing
    {
        static void Main(string[] args)
        {
            int prodNumber; // Declare product number.
            decimal unitPrice; // Declare unit price.
            int prodCount; // Declare total number of products.
            decimal totalPrice; // Declare total price variable.

            Console.Write("Enter an item number: ");
            prodNumber = Convert.ToInt32(Console.ReadLine()); //read in the product number.

            Console.Write("\nEnter quantity purchased: ");
            prodCount = Convert.ToInt32(Console.ReadLine()); //read quatity purchased.

            Console.Write("\nEnter the unit price: ");
            unitPrice = Convert.ToDecimal(Console.ReadLine()); //read unit price.            

            totalPrice = unitPrice * prodCount; // Do the work!
            /*
            Console.WriteLine("\n{0}\t{1}\t{2}\t{3}", "Item Number", "Unit Price", "Quantity", "Total"); //Display column headers

            Console.WriteLine("{0}\t\t{1, 0:c}\t\t{2}\t\t{3, 0:c}", prodNumber, unitPrice, prodCount, totalPrice); //Display formatted results
            */
            Console.WriteLine("\nYou are purchasing {0} of item {1} @ {2, 0:c} each.", prodCount, prodNumber, unitPrice);
            Console.WriteLine("Your total cost is {0, 0:c}", totalPrice);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}

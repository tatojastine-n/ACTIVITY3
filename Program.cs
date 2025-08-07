using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanYouAffordIt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float price = 0;
            int quantity = 0;
            bool validInput = true;

            //get and validate price input.
            do
            {
                Console.Write("Enter item price (PHP): ");
                if (!float.TryParse(Console.ReadLine(), out price) || price <= 0)
                {
                    Console.WriteLine("Invalid price. Enter a positive number. ");
                    validInput = false;
                }
                else
                {
                    validInput = true;
                }
            } while (!validInput);
            //get and validate quantity input
            do
            {
                Console.Write("Enter quantity: ");
                if (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                {
                    Console.WriteLine("Invalid quantity. Enter a positive whole number. ");
                    validInput = false;
                }
                else
                {
                    validInput = true;
                }
            } while (!validInput);
            //calculate and display total cost 
            float total = price * quantity;
            Console.WriteLine($"Total cost: Php {total.ToString("0.00")}"); 
        }
    }
}

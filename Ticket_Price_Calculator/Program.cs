using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Price_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define ticket prices
            const int regularPrice = 10;
            const int discountedPrice = 7;

            // Prompt the user to enter their age
            Console.Write("Please enter your age: ");

            // Read the input from the user
            string input = Console.ReadLine();
            int age;

            // Validate the input to ensure it's a valid age
            if (int.TryParse(input, out age) && age >= 0)
            {
                // Determine the ticket price
                int ticketPrice;

                if (age <= 12 || age >= 65)
                {
                    ticketPrice = discountedPrice;
                }
                else
                {
                    ticketPrice = regularPrice;
                }

                // Display the ticket price
                Console.WriteLine($"The ticket price for age {age} is: GHC{ticketPrice}");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}

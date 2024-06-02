using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Type_Identifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the sides of the triangle
            Console.Write("Enter the length of side 1: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the length of side 2: ");
            string input2 = Console.ReadLine();

            Console.Write("Enter the length of side 3: ");
            string input3 = Console.ReadLine();

            // Parse the inputs to integers
            if (double.TryParse(input1, out double side1) && side1 > 0 &&
                double.TryParse(input2, out double side2) && side2 > 0 &&
                double.TryParse(input3, out double side3) && side3 > 0)
            {
                // Check if the sides form a valid triangle
                if (IsValidTriangle(side1, side2, side3))
                {
                    // Determine the type of the triangle
                    string triangleType;

                    if (side1 == side2 && side2 == side3)
                    {
                        triangleType = "Equilateral";
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        triangleType = "Isosceles";
                    }
                    else
                    {
                        triangleType = "Scalene";
                    }

                    // Display the type of the triangle
                    Console.WriteLine($"The triangle is: {triangleType}");
                }
                else
                {
                    Console.WriteLine("The entered sides do not form a valid triangle.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter positive numbers for the sides.");
            }
        }

        // Function to check if the sides form a valid triangle
        static bool IsValidTriangle(double side1, double side2, double side3)
        {
            return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a numerical grade
            Console.Write("Please enter a numerical grade (0-100): ");

            // Read the input from the user
            string input = Console.ReadLine();
            int grade;

            // Validate the input to ensure it's a number between 0 and 100
            if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
            {
                // Determine the letter grade
                string letterGrade;

                if (grade >= 90)
                {
                    letterGrade = "A";
                }
                else if (grade >= 80)
                {
                    letterGrade = "B";
                }
                else if (grade >= 70)
                {
                    letterGrade = "C";
                }
                else if (grade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                // Display the letter grade
                Console.WriteLine($"The letter grade for {grade} is: {letterGrade}");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }
    }
}

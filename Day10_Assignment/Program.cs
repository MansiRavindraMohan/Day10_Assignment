using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the person's age: ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    throw new InvalidAgeException("Age cannot be empty or null.");

                if (int.TryParse(input, out int age))
                {
                    string category = AgeCatagorizer.GetAgeCategory(age);
                    Console.WriteLine($"Age category: {category}");
                }
                else
                {
                    throw new InvalidAgeException("Invalid age format. Please enter a valid number.");
                }
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}

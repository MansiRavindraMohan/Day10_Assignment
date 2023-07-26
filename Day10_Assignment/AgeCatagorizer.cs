using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Assignment
{
    public class AgeCatagorizer
    {
        public static string GetAgeCategory(int age)
        {
            if (age >= 1 && age <= 14)
                return "Children";
            else if (age >= 15 && age <= 24)
                return "Youth";
            else if (age >= 25 && age <= 64)
                return "Adults";
            else if (age >= 65)
                return "Seniors";
            else
                throw new InvalidAgeException("Invalid age entered.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace RegexPatternProblems 
{
    public class RegexPattern 
    {
        //Method to check and take the first name using regex(UC1)
        public void CheckFirstName()
        {
            string firstName = Console.ReadLine();
            //Pattern for checking the first name that starts with cap and has min 3 characters(UC1)
            string fNamePattern = "(^[A-Z]{1}[a-z]{2,}$)";
            if (Regex.IsMatch(firstName, fNamePattern)) 
            { 
                Console.WriteLine("\tThe given name is valid");
            } 
            else
            {
                Console.WriteLine("\tThe given name is not valid");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
namespace RegexPatternProblems 
{
<<<<<<< HEAD
    public class RegexPattern 
=======
    public class RegexPattern
>>>>>>> UC2_ValidLastName
=======
namespace RegexPatternProblems
{
    public class RegexPattern
>>>>>>> UC5_PasswordRule-1
=======
namespace RegexPatternProblems
{
    public class RegexPattern
>>>>>>> UC6_PasswordRule-2
=======
namespace RegexPatternProblems
{
    public class RegexPattern
>>>>>>> UC7_PasswordRule-3
    {
        //Method to check and take the first name using regex(UC1)
        public void CheckFirstName()
        {
            string firstName = Console.ReadLine();
            //Pattern for checking the first name that starts with cap and has min 3 characters(UC1)
            string fNamePattern = "(^[A-Z]{1}[a-z]{2,}$)";
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            if (Regex.IsMatch(firstName, fNamePattern)) 
            { 
                Console.WriteLine("\tThe given name is valid");
            } 
            else
            {
                Console.WriteLine("\tThe given name is not valid");
=======
=======
>>>>>>> UC5_PasswordRule-1
=======
>>>>>>> UC6_PasswordRule-2
=======
>>>>>>> UC7_PasswordRule-3
            if (Regex.IsMatch(firstName, fNamePattern))
            {
                Console.WriteLine("\tThe entered first name is valid");
            }
            else
            {
                Console.WriteLine("\tFirst name should starts with Cap and should have minimum 3 characters");
            }
        }
        //Method to check and take the last name using regex(UC2)
        public void CheckLastName()
        {
            string lastName = Console.ReadLine();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            //Pattern for checking the last name that starts with cap and has minimum 3 characters(UC2)
=======
            //Pattern for checking the last name that starts with cap and has min 3 characters(UC2)
>>>>>>> UC5_PasswordRule-1
=======
            //Pattern for checking the last name that starts with cap and has min 3 characters(UC2)
>>>>>>> UC6_PasswordRule-2
=======
            //Pattern for checking the last name that starts with cap and has min 3 characters(UC2)
>>>>>>> UC7_PasswordRule-3
            string lNamePattern = "(^[A-Z]{1}[a-z]{2,}$)";
            if (Regex.IsMatch(lastName, lNamePattern))
            {
                Console.WriteLine("\tThe given last name is valid");
            }
            else
            {
                Console.WriteLine("\tLast name should starts with Cap and should have minimum 3 characters");
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> UC2_ValidLastName
=======
=======
>>>>>>> UC6_PasswordRule-2
=======
>>>>>>> UC7_PasswordRule-3
            }
        }
        //Method to check and take the valid email using regex(UC3)
        public void CheckEmail()
        {
            string emailId = Console.ReadLine();
            //Pattern for checking the email id(UC3)
            string emailIdPattern = "^[a-zA-Z0-9]{3,7}([._+-][0-9a-zA-Z]{1,7})*@[0-9a-zA-Z]+[.]?([a-zA-Z]{2,4})+[.]?([a-zA-Z]{2,3})*$";
            if (Regex.IsMatch(emailId, emailIdPattern))
            {
                Console.WriteLine("\tThe given email id is valid");
            }
            else
            {
                Console.WriteLine("\tThe given email id is not valid");
            }
        }
        //Method to check and take the valid mobile number using regex(UC4)
        public void CheckMobileNumber()
        {
            string mobileNum = Console.ReadLine();
            //Pattern for checking the mobile number(UC4)
            string mobNumPattern = "^91[ ][1-9][0-9]{9}$";
            if (Regex.IsMatch(mobileNum, mobNumPattern))
            {
                Console.WriteLine("\tThe given mobile number is valid");
            }
            else
            {
                Console.WriteLine("\tThe number should follow 91 10 digits E.g. 91 9919819801");
            }
        }
<<<<<<< HEAD
<<<<<<< HEAD
        //Method to check and take the valid password using regex(UC5)
        public void CheckPassword()
        {
            string password = Console.ReadLine();
            //Pattern for checking the password(UC5)
            string passwordPattern = "^[a-zA-Z]{8,}$";
=======
        //Method to check and take the valid password using regex(UC5 & UC6)
        public void CheckPassword()
        {
            string password = Console.ReadLine();
            //Pattern for checking the password for having atleast one uppercase(UC5 & UC6)
            string passwordPattern = "^(?=.*[A-Z])[0-9a-zA-Z]{8,}$";
>>>>>>> UC6_PasswordRule-2
=======
        //Method to check and take the valid password using regex(UC5,UC6 & UC7)
        public void CheckPassword()
        {
            string password = Console.ReadLine();
            //Pattern for checking the password for having atleast one uppercase and number(UC5,UC6 & UC7)
            string passwordPattern = "^(?=.*[A-Z])(?=.*[0-9])[0-9a-zA-Z]{8,}$";
>>>>>>> UC7_PasswordRule-3
            if (Regex.IsMatch(password, passwordPattern))
            {
                Console.WriteLine("\tThe given password is valid");
            }
            else
            {
                Console.WriteLine("\tThe given password is not valid");
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> UC5_PasswordRule-1
=======
>>>>>>> UC6_PasswordRule-2
=======
>>>>>>> UC7_PasswordRule-3
            }
        }
    }
}
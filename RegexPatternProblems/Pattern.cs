using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternProblems
{
    //Class name.
   public class Pattern 
   {
        //Create a pattern for a first name thats start with cap and has min 3 characters (UC1)
        public static string FIRST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$"; //Minimum 3 Characters
        //Method For Validate First Name using regex(UC1).
        public bool validateFirstName(string fname) 
        { 
            return Regex.IsMatch(fname, FIRST_NAME_REGEX);
        }
        //Create a pattern for a last name thats start with cap and has min 3 characters (UC2)
        public static string LAST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$"; //Minimum 3 Characters(Ram)
        //Method For Validate Last Name using regex(UC2).
        public bool validateLastName(string lname)
        {
            return Regex.IsMatch(lname, LAST_NAME_REGEX);
        }

         //Create a pattern for a Email thats start with cap and has 3 mandatory parts(UC3)
        public static string EMAIL_REGEX = "^[a-zA-Z0-9.]+@[a-zA-Z0-9]+.[a-zA-Z0-9]+.[a-zA-Z]{2,4}$"; //eg:-abc.xyz@bl.co.in

        //Method For Validate Email Address
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, EMAIL_REGEX);
        }
        //Create a pattern for a defined Mobile Formate and country code follow by space and 10 digit number(UC4).
        public static string MOBILE_NUMBER_REGEX = "^[1-9]{2}[6-9]{1}[0-9]{9}$";
        //Method For Validate Mobile Number With Country Code using regex(UC4).
        public bool validateMobileNumber(string mnumber)
        {
            return Regex.IsMatch(mnumber, MOBILE_NUMBER_REGEX);
        }
   }
}

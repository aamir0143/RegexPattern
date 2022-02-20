using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
namespace RegexPatternProblems 
{
    class Program
    {
<<<<<<< HEAD
        //Takes an input from the user.
        private static readonly string instr = Console.ReadLine();
        //Main method
=======
>>>>>>> UC1_ValidFirstName
=======
=======
>>>>>>> UC5_PasswordRule-1
=======
>>>>>>> UC6_PasswordRule-2
=======
>>>>>>> UC7_PasswordRule-3
namespace RegexPatternProblems
{
    class Program
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> UC2_ValidLastName
=======
>>>>>>> UC5_PasswordRule-1
=======
>>>>>>> UC6_PasswordRule-2
=======
>>>>>>> UC7_PasswordRule-3
        static void Main(string[] args)
        {
            //Displaying the welcome message
            Console.WriteLine("==========Welcome To User Registration Problems==========");
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            Pattern program = new Pattern();
            Console.WriteLine("-->Please Choose To Which Program Is Executed<--");
            Console.WriteLine("1.Enter First Name \n2.Enter Last Name \n3.Enter Email \n4.Enter Mobile Numbers \n5.Enter Password Rule-1 \n6.Enter Password Rule-2 \n7.Enter Password Rule-3 \n8.Enter Password Rule-4 \n9.Check All Email Samples \n10.Exit");
            Console.Write("Select Above Number:-> ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Write("Enter First Name: ");
                    Console.WriteLine(program.validateFirstName(instr));//Print the output
                    break;
                case 2:
                    Console.WriteLine(program.validateLastName(instr));//Print the output
                    break;
                case 3:
                    Console.WriteLine(program.validateEmail(instr));//Print the output
                    break;
                case 4:
                    Console.WriteLine(program.validateMobileNumber(instr));//Print the output
                    break;
                case 5:
                    Console.WriteLine(program.PasswordRule1(instr));//Print the output
                    break;
                case 6:
                    Console.WriteLine(program.PasswordRule2(instr));//Print the output
                    break;
                case 7:
                    Console.WriteLine(program.PasswordRule3(instr));//Print the output
                    break;
                case 8:
                    Console.WriteLine(program.PasswordRule4(instr));//Print the output
                    break;
                case 9:
                    bool isCheckAnother = true;
                    while (isCheckAnother)
                    {
                        Console.WriteLine("Type new Email: ");
                        string testMail = Console.ReadLine();
                        Console.WriteLine(program.validateEmail(testMail));
                        Console.WriteLine("Need to check anorher ? \n1.YES \n2.NO");
                        int ar = Convert.ToInt32(Console.ReadLine());
                        if (ar == 2)
                        {
                            isCheckAnother = false;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Please Select Correct Number");
                    break; 
=======
            RegexPattern pattern = new RegexPattern();//Create Objects
            bool flag = true;
            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("\t-->Select To Programs Which can be executed<--");
                Console.WriteLine("\t1.Enter First Name \n\t2.Exit");
=======
            RegexPattern pattern = new RegexPattern();//Create Objects
            bool flag = true;
            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("\t-->Select To Programs Which can be executed<--");
                Console.WriteLine("\t1.Enter First Name \n\t2.Enter Last Name \n\t3.Exit");
>>>>>>> UC2_ValidLastName
=======
            RegexPattern pattern = new RegexPattern();//Create Objects
            bool flag = true;
            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("\t-->Select To Programs Which can be executed<--");
                Console.WriteLine("\t1.Enter First Name \n\t2.Enter Last Name \n\t3.Enter Your Email Id \n\t4.Enter Your Mobile Numbers \n\t5.Enter Your Password Rule-1 \n\t6.Exit");
>>>>>>> UC5_PasswordRule-1
=======
            RegexPattern pattern = new RegexPattern();//Create Objects
            bool flag = true;
            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("\t-->Select To Programs Which can be executed<--");
                Console.WriteLine("\t1.Enter First Name \n\t2.Enter Last Name \n\t3.Enter Your Email Id \n\t4.Enter Your Mobile Numbers \n\t5.Enter Your Password Rule-1 \n\t6.Exit");
>>>>>>> UC6_PasswordRule-2
=======
            RegexPattern pattern = new RegexPattern();//Create Objects
            bool flag = true;
            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("\t-->Select To Programs Which can be executed<--");
                Console.WriteLine("\t1.Enter First Name \n\t2.Enter Last Name \n\t3.Enter Your Email Id \n\t4.Enter Your Mobile Numbers \n\t5.Enter Your Password Rule-1 \n\t6.Exit");
>>>>>>> UC7_PasswordRule-3
                Console.Write("\tEnter Numbers: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        //Validating user entered a valid firstname or not(UC1)
                        Console.Write("\tEnter Your First Name: ");
                        pattern.CheckFirstName();//Call the Method.
                        break;
                    case 2:
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> UC5_PasswordRule-1
=======
>>>>>>> UC6_PasswordRule-2
=======
>>>>>>> UC7_PasswordRule-3
                        //Validating user entered a valid Lastname or not(UC2)
                        Console.Write("\tEnter Your Last Name: ");
                        pattern.CheckLastName();//Call the Method.
                        break;
                    case 3:
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> UC2_ValidLastName
=======
=======
>>>>>>> UC6_PasswordRule-2
=======
>>>>>>> UC7_PasswordRule-3
                        //Validating user entered a valid Email id or not(UC3)
                        Console.Write("\tEnter Your Email Id: ");
                        pattern.CheckEmail();//Call the Method.
                        break;
                    case 4:
                        //Validating user entered a valid Mobile Numbers or not(UC4)
                        Console.Write("\tEnter Your Mobile Numbers: ");
                        pattern.CheckMobileNumber();//Call the Method.
                        break;
                    case 5:
<<<<<<< HEAD
<<<<<<< HEAD
                        //Validating user entered a valid Password or not(UC5)
=======
                        //Validating user entered a valid Password or not(UC5&UC6)
>>>>>>> UC6_PasswordRule-2
=======
                        //Validating user entered a valid Password or not(UC5&UC6&UC7)
>>>>>>> UC7_PasswordRule-3
                        Console.Write("\tEnter Your Password: ");
                        pattern.CheckPassword();//Call the Method. 
                        break;
                    case 6:
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> UC5_PasswordRule-1
=======
>>>>>>> UC6_PasswordRule-2
=======
>>>>>>> UC7_PasswordRule-3
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\tSelect Correct Number");
                        break;
                }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> UC1_ValidFirstName
=======
>>>>>>> UC2_ValidLastName
=======
>>>>>>> UC5_PasswordRule-1
=======
>>>>>>> UC6_PasswordRule-2
=======
>>>>>>> UC7_PasswordRule-3
            }
        }
    }
}
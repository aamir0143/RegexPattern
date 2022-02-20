using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        static void Main(string[] args)
        {
            //Displaying the welcome message
            Console.WriteLine("==========Welcome To User Registration Problems==========");
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
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\tSelect Correct Number");
                        break;
                }
>>>>>>> UC1_ValidFirstName
            }
            Console.WriteLine("==================================================================");
            Console.ReadLine();
        }
    }
}
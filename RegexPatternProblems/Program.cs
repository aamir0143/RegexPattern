// See https://aka.ms/new-console-template for more information
using System;
namespace RegexPatternProblems
{
    class Program
    {
        //Takes an input from the user.
        private static readonly string instr = Console.ReadLine();
        //Main method
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To User Registration Problems==========");
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
            }
            Console.WriteLine("==================================================================");
            Console.ReadLine();
        }
    }
}
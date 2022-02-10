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
            Console.WriteLine("1.validateFirstName \n2.validateLastName \n3.validateEmail \n4.validateMobileNumber \n5.PasswordRule1 \n6.PasswordRule2 \n7.PasswordRule3 \n8.PasswordRule4 \n9.Exit");
            Console.Write("Select Above Number:-> ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
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
                default:
                    Console.WriteLine("Please Select Correct Number");
                    break;  
            }
            Console.WriteLine("==================================================================");
            Console.ReadLine();
        }
    }
}
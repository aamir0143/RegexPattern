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
            Console.WriteLine("1.validateFirstName \n2.validateLastName \n3.Exit");
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
                default:
                    Console.WriteLine("Please Select Correct Number");
                    break;  
            }
        }
    }
}
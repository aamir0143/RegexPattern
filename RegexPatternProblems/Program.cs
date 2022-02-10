// See https://aka.ms/new-console-template for more information
using System;
namespace RegexPatternProblems
{
    class Program
    {
        public static string instr = Console.ReadLine();
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To User Registration Problems==========");
            Pattern program = new Pattern();
            Console.WriteLine("-->Please Choose To Which Program Is Executed<--");
            Console.WriteLine("1.validateFirstName \n2.Exit");
            Console.Write("Select Above Number:-> ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine(program.validateFirstName(instr));
                    break;
                case 2:
                default:
                    Console.WriteLine("Please Select Correct Number");
                    break;  
            }
        }
    }
}
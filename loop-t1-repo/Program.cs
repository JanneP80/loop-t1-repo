using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_t1_repo
{
    class Program
    {
        static void Main(string[] args)
        {
            // program prints N!

            int n = 0;
            int solution = 0;
            string message = string.Empty;
            Console.Write("Pleas type number for calculating N!");

            bool userinput = int.TryParse(Console.ReadLine(), out n);
            if (!userinput) // incorrect input
            {
                message = "Input is NOT a number.";
            }

            else // calculation
            {
                solution 

                message = string.Format("You typed number {0}, it's N! is {1}.", n, solution);
            }

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}

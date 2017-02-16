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
            //int runningnumber = 1;
            int solution = 1;
            string message = string.Empty;
            Console.Write("Please type number for calculating N! ");

            bool userinput = int.TryParse(Console.ReadLine(), out n);
            if (!userinput) // incorrect input
            {
                message = "Input is NOT a number.";
            }

            else // calculation
            {
                for (int runningnumber = 1; runningnumber < n+1; runningnumber++)
                {
                    Console.WriteLine("calculating... {0}", runningnumber); // error check line
                    solution = solution * runningnumber;
                                   
                }
                     

                message = string.Format("You typed number {0}, it's N! is {1}.", n, solution);
            }

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}

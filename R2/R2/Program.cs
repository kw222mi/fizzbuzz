using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" R2 – Calculate the missing number ");
            Console.WriteLine("You will enter two integers separated by a space:");
            Console.WriteLine("- R1: the first number");
            Console.WriteLine("- S:  the mean (average) of R1 and R2");
            Console.WriteLine("The program will calculate R2 so that (R1 + R2) / 2 = S.");
            Console.WriteLine();
            Console.Write("Enter R1 and S: ");

            string[] input = Console.ReadLine().Split(' ');
            int R1 = int.Parse(input[0]);
            int S = int.Parse(input[1]);

            int R2 = 2 * S - R1;

            Console.WriteLine();
            Console.WriteLine($"The value of R2 is: {R2}");

        }
    }
}

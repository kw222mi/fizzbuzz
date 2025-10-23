using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasty_Hacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nasty Hacks – Should you advertise?");
            Console.WriteLine("This program helps you decide whether advertising is worth it.");
            Console.WriteLine("For each test case, enter three integers separated by spaces:");
            Console.WriteLine("- r: revenue without advertising");
            Console.WriteLine("- e: expected revenue with advertising");
            Console.WriteLine("- c: cost of advertising");
            Console.WriteLine();
            Console.WriteLine("You will first enter the number of test cases.");
            Console.WriteLine("For each case, the program will print:");
            Console.WriteLine("- 'advertise' if advertising increases profit");
            Console.WriteLine("- 'does not matter' if profit is the same");
            Console.WriteLine("- 'do not advertise' if advertising decreases profit");
            Console.WriteLine();

            Console.Write("Enter number of test cases: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Now enter {n} lines with three numbers each (r e c):");

            for (int i = 0; i<n; i++)
            {
                string[] parts = Console.ReadLine().Split(' ');
                int revenue = int.Parse(parts[0]);
                int expectedRevenue = int.Parse(parts[1]);
                int cost = int.Parse(parts[2]);

                int profitWithAd = expectedRevenue - cost;

                if (profitWithAd > revenue)
                    Console.WriteLine("advertise");
                else if (profitWithAd == revenue)
                    Console.WriteLine("does not mater");
                else 
                    Console.WriteLine("do not advvertise");
                

            }
        }
    }
}

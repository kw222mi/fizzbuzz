using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackingCups
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stacking Cups – Sort by cup size");
            Console.Write("Enter number of cups: ");
            int n = int.Parse(Console.ReadLine());

            var cups = new List<(string color, double radius)>();

            Console.WriteLine();
            Console.WriteLine($"Enter {n} lines (either 'number color' or 'color number'):");

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(' ');

                if (int.TryParse(parts[0], out int diameter)) // format: number color
                {
                    string color = parts[1];
                    cups.Add((color, diameter / 2.0));
                }
                else // format: color number
                {
                    string color = parts[0];
                    double radius = double.Parse(parts[1]);
                    cups.Add((color, radius));
                }
            }

            var sorted = cups.OrderBy(c => c.radius);

            Console.WriteLine();
            Console.WriteLine("Cups in order from smallest to largest:");
            foreach (var cup in sorted)
            {
                Console.WriteLine(cup.color);
            }
        }
    }
}

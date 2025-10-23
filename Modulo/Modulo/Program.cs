using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Modulo – count unique remainders");
            Console.WriteLine("Enter 10 integers (one per line):");

            var remainders = new HashSet<int>();

            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                remainders.Add(num % 42);
            }

            Console.WriteLine();
            Console.WriteLine($"Number of unique remainders: {remainders.Count}");
        }
    }
}

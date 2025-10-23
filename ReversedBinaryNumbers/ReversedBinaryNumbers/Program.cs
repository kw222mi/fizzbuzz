using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_Binary_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Reversed Binary Numbers");
            Console.WriteLine("Enter a number to reverse its binary representation:");

            int input = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(input, 2);
            string reversed = new string (binary.Reverse().ToArray());
            int result = Convert.ToInt32(reversed, 2);
            Console.WriteLine($"Original binary: {binary}");
            Console.WriteLine($"Reversed binary: {reversed}");
            Console.WriteLine($"Decimal result:  {result}");


        }
    }
}

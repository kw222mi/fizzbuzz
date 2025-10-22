using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Välkommen till FizzBuzz!");
            Console.Write("Ange gränsen (t.ex. 100): ");
            int limit = int.Parse(Console.ReadLine());

            Console.Write("Ange första talet (X): ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Ange andra talet (Y): ");
            int y = int.Parse(Console.ReadLine());

            for (int i = 1; i <= limit; i++)
            {
                if (i % x == 0 && i % y == 0)
                    Console.WriteLine("fizzbuzz");
                else if (i % x == 0)
                    Console.WriteLine("fizz");
                else if (i % y == 0)
                    Console.WriteLine("buzz");
                else
                    Console.WriteLine(i);
            }
        }
        }
    }
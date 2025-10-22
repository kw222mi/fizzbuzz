using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till timeLoop välj antal gånger abrakadabra ska " +
                "läsas upp för att bryta förtrollningen");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} Abracadabra");
            }
        }
    }
}

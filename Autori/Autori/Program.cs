using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Shorten Scientific Name");
            Console.WriteLine("This program converts a long scientific name (e.g. 'Knuth-Morris-Pratt')");
            Console.WriteLine("into its short form using only the initials (e.g. 'KMP').");
            Console.WriteLine();
            Console.Write("Enter the full scientific name: ");

            var parts = Console.ReadLine().Split('-');
            var acronym = string.Concat(parts.Select(p => p[0]));
            Console.WriteLine(acronym);
        }
    }
}

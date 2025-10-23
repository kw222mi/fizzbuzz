using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Poker Hand – Find the largest group of same rank");
            Console.WriteLine("Enter 5 cards (e.g. 'TH JH QH QD QS'):");
            string[] cards = Console.ReadLine().Split(' ');

            var counts = new Dictionary<char, int>();

            foreach (string card in cards)
            {
                char rank = card[0]; 
                if (!counts.ContainsKey(rank))
                    counts[rank] = 0;
                counts[rank]++;
            }

            int maxGroup = counts.Values.Max();

            Console.WriteLine();
            Console.WriteLine($"Largest group of same rank: {maxGroup}");
        }
    }
}

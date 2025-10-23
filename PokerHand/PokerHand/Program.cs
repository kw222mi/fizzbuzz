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

            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A" };
            string[] suits = { "S", "H", "D", "C" }; 

            List<string> deck = new List<string>();

            foreach (string rank in ranks)
            {
                foreach (string suit in suits)
                {
                    deck.Add(rank + suit);
                }
            }

            Random random = new Random();
            deck = deck.OrderBy(x => random.Next()).ToList();

            List<string> hand = deck.Take(5).ToList();

            Console.WriteLine("Your random hand:");
            Console.WriteLine(string.Join(" ", hand));


            var counts = new Dictionary<char, int>();

            foreach (string card in hand)
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

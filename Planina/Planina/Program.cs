using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Planina – Calculate number of points");
            Console.Write("Enter the number of iterations (N): ");

            int n = int.Parse(Console.ReadLine());
            int pointsPerSide = (int)Math.Pow(2, n) + 1;
            int totalPoints = pointsPerSide * pointsPerSide;

            Console.WriteLine($"Total number of points: {totalPoints}");
        }
    }
}

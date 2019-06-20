using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._Find_Evens_or_Odds
{
    class FindEvenOdds
    {
        static void Main()
        {
            int[] rangeNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int min = rangeNumbers[0];
            int max = rangeNumbers[1];

            string command = Console.ReadLine();

            List<int> numbers = new List<int>();

            Predicate<int> filter = x => command == "odd" ? x % 2 != 0 : x % 2 == 0;   

            for (int i = min; i <= max; i++)
            {
                numbers.Add(i);
            }

            Console.WriteLine(string.Join(" ", numbers.Where(x => filter(x))));
        }
    }
}

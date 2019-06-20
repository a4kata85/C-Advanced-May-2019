using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Count_Symbols
{
    class CounrSymbols
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            Dictionary<char, int> symbolTimes = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                if (symbolTimes.ContainsKey(symbol) == false)
                {
                    symbolTimes[symbol] = 0;
                }
                symbolTimes[symbol]++;

            }

            foreach (var kvp in symbolTimes.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}

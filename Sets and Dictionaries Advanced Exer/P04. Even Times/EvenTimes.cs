using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._Even_Times
{
    class EvenTimes
    {
        static void Main()
        {
            int countLines = int.Parse(Console.ReadLine());

            Dictionary<int, int> numberCount = new Dictionary<int, int>();

            for (int i = 0; i < countLines; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (numberCount.ContainsKey(currentNumber) == false)
                {
                    numberCount[currentNumber] = 0;
                }
                numberCount[currentNumber]++;
            }

            foreach (var item in numberCount)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
            
        }
    }
}

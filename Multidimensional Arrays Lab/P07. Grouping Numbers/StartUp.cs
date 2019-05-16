using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Grouping_Numbers
{
    class StartUp
    {
        static void Main()
        {
            int[] allNumbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            List<int> zeroList = new List<int>();
            List<int> oneList = new List<int>();
            List<int> twoList = new List<int>();


            for (int i = 0; i < allNumbers.Length; i++)
            {
                int currentNumber = allNumbers[i];
                if (Math.Abs(currentNumber) % 3 == 0)
                {
                    zeroList.Add(currentNumber);
                }
                else if (Math.Abs(currentNumber) % 3 == 1)
                {
                    oneList.Add(currentNumber);
                }
                else if (Math.Abs(currentNumber) % 3 == 2)
                {
                    twoList.Add(currentNumber);
                }
            }

            Console.WriteLine(string.Join(" ", zeroList));
            Console.WriteLine(string.Join(" ", oneList));
            Console.WriteLine(string.Join(" ", twoList));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.Count_Same_Values_in_Array
{
    class CountSameValues
    {
        static void Main()
        {
            // -2.5 4 3 -2.5 -5.5 4 3 3 -2.5 3

            double[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> dictCounter = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (dictCounter.ContainsKey(number))
                {
                    dictCounter[number]++;
                }
                else
                {
                    dictCounter.Add(number, 1);
                }
            }

            foreach (var item in dictCounter)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Sets_of_Elements
{
    class SetsOfElements
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int setOneLenght = numbers[0];
            int setTwoLenght = numbers[1];

            HashSet<int> setOneNumbers = new HashSet<int>();
            HashSet<int> setTwoNumbers = new HashSet<int>();

            List<int> printList = new List<int>();

            for (int i = 0; i < setOneLenght; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                setOneNumbers.Add(currentNumber);
            }

            for (int i = 0; i < setTwoLenght; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                setTwoNumbers.Add(currentNumber);
            }

            foreach (var number in setOneNumbers)
            {
                if (setTwoNumbers.Contains(number))
                {
                    printList.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", printList));
        }
    }
}

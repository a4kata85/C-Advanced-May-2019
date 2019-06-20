using System;
using System.Collections.Generic;
using System.Linq;

namespace Socks
{
    class StartUp
    {
        static void Main()
        {
            int[] leftNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> leftSocks = new Stack<int>(leftNumbers);

            int[] rightNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> rightSocks = new Queue<int>(rightNumbers);

            List<int> finalSets = new List<int>();

            while (rightSocks.Count > 0 && leftSocks.Count > 0)
            {
                int leftElement = leftSocks.Peek();
                int rightElement = rightSocks.Peek();

                if (leftElement > rightElement)
                {
                    int set = leftElement + rightElement;
                    finalSets.Add(set);
                    leftSocks.Pop();
                    rightSocks.Dequeue();
                }
                else if (rightElement > leftElement)
                {
                    leftSocks.Pop();
                }
                else
                {
                    rightSocks.Dequeue();
                    int incrementedValue = leftElement + 1;
                    leftSocks.Pop();
                    leftSocks.Push(incrementedValue);
                }
            }

            Console.WriteLine(finalSets.Max());
            Console.WriteLine(string.Join(" ", finalSets));
          
        }
    }
}

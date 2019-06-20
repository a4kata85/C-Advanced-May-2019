using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Periodic_Table
{
    class PeriodicTable
    {
        static void Main()
        {
            int countLines = int.Parse(Console.ReadLine());

            HashSet<string> uniqueElements = new HashSet<string>();

            for (int i = 0; i < countLines; i++)
            {
                string[] elements = Console.ReadLine().Split();

                for (int j = 0; j < elements.Length; j++)
                {
                    uniqueElements.Add(elements[j]);
                }
            }
          
                Console.WriteLine(string.Join(" ", uniqueElements.OrderBy(x=>x)));
        }
    }
}

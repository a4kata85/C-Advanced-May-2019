using System;
using System.Collections.Generic;
using System.Linq;

namespace P13._TriFunction
{
    class TriFunction
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            for (int i = 0; i < names.Count; i++)
            {
                string name = names[i];
                int sum = 0;
                for (int j = 0; j < name.Length; j++)
                {
                    sum += name[j];
                }
                if (sum >= number)
                {
                    Console.WriteLine(name);
                    break;
                }
            }
        }
    }
}

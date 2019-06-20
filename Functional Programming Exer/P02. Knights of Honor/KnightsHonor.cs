using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Knights_of_Honor
{
    class KnightsHonor
    {
        static void Main()
        {
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, string> format = x => $"Sir {x}";

            Action<List<string>> print = x => Console.WriteLine(string.Join(Environment.NewLine, x.Select(format)));

            print(names);

        }
    }
}

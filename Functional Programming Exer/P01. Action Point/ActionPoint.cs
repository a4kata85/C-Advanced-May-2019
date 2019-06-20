using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Action_Point
{
    class ActionPoint
    {
        static void Main()
        {
            List<string> names = Console.ReadLine().Split().ToList();

            Action<List<string>> print = x => Console.WriteLine(string.Join(Environment.NewLine, x));

            print(names);
        }
    }
}

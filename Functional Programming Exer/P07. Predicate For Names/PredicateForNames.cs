using System;
using System.Linq;
using System.Collections.Generic;

namespace P07._Predicate_For_Names
{
    class PredicateForNames
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());

            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Print(names, n => n.Length <= lenght);
        }

        public static void Print(IEnumerable<string> collection, Func<string, bool> Filter)
        {
            Console.WriteLine(string.Join(Environment.NewLine, collection.Where(Filter)));
        }
    }
}

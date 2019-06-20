using System;
using System.Collections.Generic;

namespace P05._Record_Unique_Names
{
    class UniqueNames
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var person in names)
            {
                Console.WriteLine(person);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._SoftUni_Party
{
    class Party
    {
        static void Main()
        {
            HashSet<string> guests = new HashSet<string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "PARTY")
                {
                    break;
                }

                if (line.Length != 8)
                {
                    continue;
                }

                guests.Add(line);
            }

            while (true)
            {
                string currentName = Console.ReadLine();
                if (currentName == "END")
                {
                    break;
                }

                if (guests.Contains(currentName))
                {
                    guests.Remove(currentName);
                }
            }

            List<string> addList = new List<string>();
            Console.WriteLine(guests.Count);
            foreach (var name in guests)
            {
                if (char.IsDigit(name[0]))
                {
                    Console.WriteLine(name);
                }
                else
                {
                    addList.Add(name);
                }
            }

            foreach (var item in addList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

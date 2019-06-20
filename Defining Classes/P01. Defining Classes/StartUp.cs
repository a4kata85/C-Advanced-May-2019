using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int countPeople = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < countPeople; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                int ages = int.Parse(info[1]);

                Person person = new Person(name, ages);

                if (ages > 30)
                {
                    people.Add(person);
                }
            }

            foreach (Person person in people.OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace P04._Cities_by_Continent_and_Country
{
    class Cities
    {
        static void Main()
        {
            int countLines = int.Parse(Console.ReadLine());
            var dictContCountryCity = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < countLines; i++)
            {
                // Europe Bulgaria Sofia
                string[] splitedLine = Console.ReadLine().Split(" ");
                string continent = splitedLine[0];
                string country = splitedLine[1];
                string city = splitedLine[2];

                if (dictContCountryCity.ContainsKey(continent) == false)
                {
                    dictContCountryCity.Add(continent, new Dictionary<string,  List<string>>());
                    
                }

                if (!dictContCountryCity[continent].ContainsKey(country))
                {
                    dictContCountryCity[continent][country] = new List<string>();
                }

                dictContCountryCity[continent][country].Add(city);
            }

            foreach (var kvp in dictContCountryCity)
            {
                string continent = kvp.Key;
                Console.WriteLine($"{continent}:");

                foreach (var cityTowns in kvp.Value)
                {
                    string country = cityTowns.Key;

                    Console.WriteLine($"{country} -> {string.Join(", ", cityTowns.Value)}");
                }
            }
        }
    }
}

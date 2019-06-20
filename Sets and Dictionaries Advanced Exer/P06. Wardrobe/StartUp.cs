using System;
using System.Collections.Generic;

namespace P06._Wardrobe
{
    class StartUp
    {
        static void Main()
        {
            int readingLines = int.Parse(Console.ReadLine());

            var colorClothCount = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < readingLines; i++)
            {
                //Red -> dress,t-shirt,boxers
                string[] line = Console.ReadLine().Split(" -> ");
                string color = line[0];
                string[] clothes = line[1].Split(",");

                if (colorClothCount.ContainsKey(color) == false)
                {
                    colorClothCount[color] = new Dictionary<string, int>();
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string cloth = clothes[j];
                    if (colorClothCount[color].ContainsKey(cloth) == false)
                    {
                        colorClothCount[color].Add(cloth, 0);
                    }
                    colorClothCount[color][cloth]++;
                }
            }

            string[] searchingElements = Console.ReadLine().Split();
            string searchedColor = searchingElements[0];
            string searchedCloth = searchingElements[1];

            foreach (var kvp in colorClothCount)
            {
                string color = kvp.Key;
                var clothCount = kvp.Value;
                Console.WriteLine($"{color} clothes:");

                foreach (var kvpClothCount in clothCount)
                {
                    string cloth = kvpClothCount.Key;
                    int count = kvpClothCount.Value;

                    if (color == searchedColor && cloth == searchedCloth)
                    {
                        Console.WriteLine($"* {cloth} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth} - {count}");
                    }
                }
            }
        }
    }
}

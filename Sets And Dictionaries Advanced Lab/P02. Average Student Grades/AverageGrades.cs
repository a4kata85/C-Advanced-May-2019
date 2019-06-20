using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Average_Student_Grades
{
    class AverageGrades
    {
        static void Main()
        {
            int countNames = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> dictGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < countNames; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = line[0];
                double grade = double.Parse(line[1]);

                if (!dictGrades.ContainsKey(name))
                {
                    dictGrades[name] = new List<double> {grade};  
                }
                else
                {
                    dictGrades[name].Add(grade);
                }
            }

            foreach (var item in dictGrades.OrderByDescending(x => x.Value.Average()))
            {
                Console.Write($"{item.Key} -> ");
                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {item.Value.Average():f2})");
                //Console.WriteLine();
            }
        }
    }
}

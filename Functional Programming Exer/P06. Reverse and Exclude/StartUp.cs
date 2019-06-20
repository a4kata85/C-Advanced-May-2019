using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._Reverse_and_Exclude
{
    class StartUp
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
                

            int devider = int.Parse(Console.ReadLine());

            Func<int, bool> filter = n => n % devider != 0;

            var remainingNumbers = numbers.Reverse().Where(filter);

            Console.WriteLine(string.Join(" ", remainingNumbers));
        }
    }
}

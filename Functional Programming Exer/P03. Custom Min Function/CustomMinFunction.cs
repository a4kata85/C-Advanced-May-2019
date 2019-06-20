using System;
using System.Linq;

namespace P03._Custom_Min_Function
{
    class CustomMinFunction
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> minNumber = x => x.Min();
            Console.WriteLine(minNumber(numbers));
        }
    }
}

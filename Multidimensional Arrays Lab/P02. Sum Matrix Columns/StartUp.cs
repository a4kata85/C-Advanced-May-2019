using System;
using System.Linq;

namespace P02._Sum_Matrix_Columns
{
    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = numbers[0];
            int columns = numbers[1];

            int[,] someMatrix = new int[rows, columns];

            for (int i = 0; i < someMatrix.GetLength(0); i++)
            {
                int[] col = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < someMatrix.GetLength(1); j++)
                {
                    someMatrix[i, j] = col[j];
                }
            }

            for (int i = 0; i < someMatrix.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < someMatrix.GetLength(0); j++)
                {
                    sum += someMatrix[j, i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}

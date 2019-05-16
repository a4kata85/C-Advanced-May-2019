using System;
using System.Linq;

namespace P03._Primary_Diagonal
{
    class StartUp
    {
        static void Main()
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeMatrix, sizeMatrix];

            int sum = 0;
            int diagonalElement = 0;

            for (int i = 0; i < sizeMatrix; i++)
            {
                int[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < currentRow.Length; j++)
                {
                    matrix[i, j] = currentRow[j];
                    if (i == j)
                    {
                        diagonalElement = matrix[i, j];
                        sum += diagonalElement;
                    }
                }
            }

            Console.WriteLine(sum);

            
        }
    }
}

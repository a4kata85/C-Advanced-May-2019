using System;
using System.Linq;

namespace P03._Maximal_Sum
{
    class StartUp
    {
        static void Main()
        {
            int[] sizesOfArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = sizesOfArray[0];
            int cols = sizesOfArray[1];

            int[,] matrix = new int[rows, cols];

            int rowIndex = 0;
            int colIndex = 0;

            int maxSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    int tempSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                                + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                                + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int i = rowIndex; i < rowIndex + 3; i++)
            {
                for (int j = colIndex; j < colIndex + 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

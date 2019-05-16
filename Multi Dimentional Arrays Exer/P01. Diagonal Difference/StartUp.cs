using System;
using System.Linq;

namespace P01._Diagonal_Difference
{
    class StartUp
    {
        static void Main()
        {
            int sizeMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeMatrix, sizeMatrix];

            int sumPrimaryDiagonal = 0;
            int sumSecondaryDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] lineNumbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = lineNumbers[j];
                    if (i == j)
                    {                       
                        sumPrimaryDiagonal += matrix[i, j];
                    }
                    if (j == matrix.GetLength(1) - 1 - i)
                    {
                        sumSecondaryDiagonal += matrix[i, j];
                    }
                }              
            }           

            Console.WriteLine(Math.Abs(sumPrimaryDiagonal-sumSecondaryDiagonal));
        }
    }
}

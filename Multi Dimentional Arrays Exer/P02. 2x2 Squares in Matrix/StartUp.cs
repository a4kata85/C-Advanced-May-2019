using System;
using System.Linq;

namespace P02._2x2_Squares_in_Matrix
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

            char[,] matrixChars = new char[rows, cols];

            int counter = 0;

            for (int row = 0; row < matrixChars.GetLength(0); row++)
            {
                char[] symbols = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrixChars.GetLength(1); col++)
                {
                    matrixChars[row, col] = symbols[col];
                }
            }

            for (int row = 0; row < matrixChars.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrixChars.GetLength(1)-1; col++)
                {
                    if (matrixChars[row,col] == matrixChars[row, col + 1]
                        && matrixChars[row, col] == matrixChars[row + 1, col]
                        && matrixChars[row + 1, col] == matrixChars[row + 1, col + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}

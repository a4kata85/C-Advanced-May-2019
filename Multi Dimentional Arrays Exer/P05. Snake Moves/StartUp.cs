using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Snake_Moves
{
    class StartUp
    {
        static void Main()
        {
            int[] sizes = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToArray();
            int rows = sizes[0];
            int cols = sizes[1];

            char[][] matrix = new char[rows][];

            var snakeStr = Console.ReadLine().ToCharArray();

            Queue<char> snakeQueue = new Queue<char>(snakeStr);

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new char[cols];
                for (int col = 0; col < cols; col++)
                {
                    char charToAdd = snakeQueue.Dequeue();
                    matrix[row][col] = charToAdd;
                    snakeQueue.Enqueue(charToAdd);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(r => string.Join("", r))));
        }
    }
}

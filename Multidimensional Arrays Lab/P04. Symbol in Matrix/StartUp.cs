using System;

namespace P04._Symbol_in_Matrix
{
    class StartUp
    {
        static void Main()
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeMatrix, sizeMatrix];
            bool isFound = false;

            for (int i = 0; i < sizeMatrix; i++)
            {
                char[] currentLineChars = Console.ReadLine().ToCharArray();
                for (int j = 0; j < currentLineChars.Length; j++)
                {
                    matrix[i, j] = currentLineChars[j];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int i = 0; i < sizeMatrix; i++)
            {
                
                for (int j = 0; j < sizeMatrix; j++)
                {
                    if (matrix[i,j] == symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        isFound = true;
                        return;
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}

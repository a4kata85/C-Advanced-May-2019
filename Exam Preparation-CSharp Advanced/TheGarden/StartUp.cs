using System;
using System.Linq;

namespace TheGarden
{
    class StartUp
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            char[][] garden = new char[rows][];

            for (int row = 0; row < garden.Length; row++)
            {
                char[] vegetables = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();
                garden[row] = vegetables;
            }

            int carrotCount = 0;
            int potatoeCount = 0;
            int lettuceCount = 0;
            int harmedVegetables = 0;

            string command = Console.ReadLine();
            while (command != "End of Harvest")
            {
                string[] tokkens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokkens.Length == 3)
                {
                    // Harvest 0 2
                    int row = int.Parse(tokkens[1]);
                    int col = int.Parse(tokkens[2]);

                    if (IsInside(garden, row, col))
                    {
                        if (garden[row][col] != ' ')
                        {
                            if (garden[row][col] == 'L')
                            {
                                lettuceCount++;
                            }
                            if (garden[row][col] == 'P')
                            {
                                potatoeCount++;
                            }
                            if (garden[row][col] == 'C')
                            {
                                carrotCount++;
                            }

                            garden[row][col] = ' ';
                        }
                    }
                }
                else if (tokkens.Length == 4)
                {
                    // Mole 1 1 right
                    int row = int.Parse(tokkens[1]);
                    int col = int.Parse(tokkens[2]);
                    string direction = tokkens[3].ToLower();

                    if (IsInside(garden, row, col))
                    {
                        if (garden[row][col] != ' ')
                        {
                            if (direction == "up")
                            {
                                for (int i = row; i >= 0; i -= 2)
                                {
                                    if (IsInside(garden, i, col) && garden[i][col] != ' ')
                                    {
                                        harmedVegetables++;
                                        garden[i][col] = ' ';
                                    }
                                }
                            }
                            else if (direction == "down")
                            {
                                for (int currentRow = row; currentRow < garden.Length; currentRow +=2)
                                {
                                    if (IsInside(garden, currentRow, col) && garden[currentRow][col] != ' ')
                                    {
                                        harmedVegetables++;
                                        garden[currentRow][col] = ' ';
                                    }
                                }
                            }
                            else if (direction == "left")
                            {
                                for (int currentCol = col; currentCol >= 0; currentCol -=2)
                                {
                                    if (IsInside(garden, row, currentCol) && garden[row][currentCol] != ' ')
                                    {
                                        harmedVegetables++;
                                        garden[row][currentCol] = ' ';
                                    }
                                }
                            }
                            else if (direction == "right")
                            {
                                for (int currentCol = col; currentCol < garden[row].Length; currentCol +=2)
                                {
                                    if (IsInside(garden, row, currentCol) && garden[row][currentCol] != ' ')
                                    {
                                        harmedVegetables++;
                                        garden[row][currentCol] = ' ';
                                    }
                                }
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }

            foreach (char[] row in garden)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            Console.WriteLine($"Carrots: {carrotCount}");
            Console.WriteLine($"Potatoes: {potatoeCount}");
            Console.WriteLine($"Lettuce: {lettuceCount}");
            Console.WriteLine($"Harmed vegetables: {harmedVegetables}");


        }

        public static bool IsInside(char[][] jaggedArray, int row, int col)
        {
            return row >= 0 && col >= 0 && row < jaggedArray.Length && col < jaggedArray[row].Length;
        }
    }
}

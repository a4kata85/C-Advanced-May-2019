using System;
using System.IO;

namespace P02._Line_Numbers
{
    class LineNumbers
    {
        static void Main()
        {
            using (var reader = new StreamReader("../../../text.txt"))
            {
                int counter = 1;

                using (var writer = new StreamWriter("../../../outputText.txt"))
                {
                    
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        int lettersCount = 0;
                        int symbolsCount = 0;

                        if (counter != 1)
                        {
                            writer.WriteLine();
                        }

                        foreach (var @char in line)
                        {
                            if (char.IsLetter(@char))
                            {
                                lettersCount++;
                            }
                            else if(char.IsPunctuation(@char))
                            {
                                symbolsCount++;
                            }
                        }

                        writer.Write($"Line {counter}: {line} ({lettersCount})({symbolsCount})");
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}

using System;
using System.IO;

namespace P01._Even_Lines
{
    class EvenLines
    {
        static void Main()
        {
            string specialSymbols = "-.,!?";
            int counter = 0;

            using (var reader = new StreamReader("../../../text.txt"))
            {
               
                using (var writer = new StreamWriter("../../../output.txt"))
                {
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }

                        
                        if (counter % 2 == 0)
                        {
                            string changedLine = string.Empty;
                            foreach (var charr in line)
                            {
                                if (specialSymbols.Contains(charr))
                                {
                                    changedLine += '@';
                                }
                                else
                                {
                                    changedLine += charr;
                                }
                            }
                            string[] splitedLine = changedLine.Split();
                            Array.Reverse(splitedLine);

                            writer.WriteLine(string.Join(" ", splitedLine));
                        }
                        counter++;
                    }
                }
            }
        }
    }
}

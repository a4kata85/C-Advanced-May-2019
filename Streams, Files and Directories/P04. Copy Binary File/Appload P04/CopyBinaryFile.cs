using System;
using System.IO;

namespace P04._Copy_Binary_File
{
    class CopyBinaryFile
    {
        static void Main()
        {
            using (var reader = new FileStream("../../../copyMe.png", FileMode.Open))
            {
                using (var writer = new FileStream("../../../copied.png", FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];
                        int biteSize = reader.Read(buffer, 0, buffer.Length);

                        if (biteSize < 1)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, biteSize);
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace P06._Parking_Lot
{
    class ParkingLot
    {
        static void Main()
        {
            HashSet<string> carNumbers = new HashSet<string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }

                string[] splitedLine = line.Split(", ");
                string command = splitedLine[0];
                string number = splitedLine[1];

                if (command == "IN")
                {
                    carNumbers.Add(number);
                }
                else
                {
                    carNumbers.Remove(number);
                }
            }
            if (carNumbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in carNumbers)
                {
                    Console.WriteLine(car);
                }
            }
            
        }
    }
}

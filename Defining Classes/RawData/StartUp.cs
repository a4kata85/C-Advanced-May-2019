
namespace RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            // 2
            // ChevroletAstro 200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4
            // {model} 
            //{engineSpeed} {enginePower} 
            //{cargoWeight} {cargoType} 
            //{tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}
            int countCars = int.Parse(Console.ReadLine());

            
            List<Car> cars = new List<Car>();

            for (int i = 0; i < countCars; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string type = input[4];

                List<Tire> tires = new List<Tire>();                

                for (int j = 0; j < 4; j+=2)
                {
                    double presure = double.Parse(input[5+j]);
                    int age = int.Parse(input[6+j]);

                    Tire tire = new Tire(age, presure);
                    tires.Add(tire);
                }

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, type);
                Car car = new Car(carModel, engine, cargo, tires);
                cars.Add(car);
            }

            string readType = Console.ReadLine();

            List<Car> resultCars = new List<Car>();

            if (readType == "fragile")
            {
                resultCars = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(s => s.Presure < 1)).ToList();
            }
            else
            {
                resultCars = cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250).ToList();
            }

            foreach (var car in resultCars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}

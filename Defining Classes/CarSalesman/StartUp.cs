using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        public static void Main()
        {
            /*
             2
             V8-101 220 50
             V4-33 140 28 B
             3
             FordFocus V4-33 1300 Silver
             FordMustang V8-101
             VolkswagenGolf V4-33 Orange 

             */

            int countEngines = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < countEngines; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = null;

                string modelEngine = tokens[0];
                int powerEngine = int.Parse(tokens[1]);

                if (tokens.Length == 2)
                {                
                    engine = new Engine(modelEngine, powerEngine);
                }
                else if (tokens.Length == 4)
                {                   
                    int displacementEngine = int.Parse(tokens[2]);
                    string efficEngine = tokens[3];

                    engine = new Engine(modelEngine, powerEngine, displacementEngine, efficEngine);
                }
                else
                {
                    bool isDisplacement = int.TryParse(tokens[2], out int displacementEngine);

                    if (isDisplacement)
                    {
                        engine = new Engine(modelEngine, powerEngine, displacementEngine);
                    }
                    else
                    {
                        engine = new Engine(modelEngine, powerEngine, tokens[2]);
                    }
                }
                engines.Add(engine);
            }

            int countCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCars; i++)
            {
                string[] infoCar = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string modelCar = infoCar[0];
                string engineModel = infoCar[1];

                Engine engine = engines.Where(x => x.Model == engineModel).FirstOrDefault();
                Car car = null;

                if (infoCar.Length == 2)
                {
                    car = new Car(modelCar, engine);
                }
                else if (infoCar.Length == 4)
                {
                    double weight = double.Parse(infoCar[2]);
                    string color = infoCar[3];
                    car = new Car(modelCar, engine, weight, color);
                }
                else
                {
                    bool isWeight = double.TryParse(infoCar[2], out double weight);

                    if (isWeight )
                    {
                        car = new Car(modelCar, engine, weight);
                    }
                    else
                    {
                        car = new Car(modelCar, engine, infoCar[2]);
                    }
                }

                cars.Add(car);
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}

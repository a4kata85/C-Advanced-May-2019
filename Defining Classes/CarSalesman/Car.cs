namespace CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car
    {
        private const string DefValueString = "n/a";
        private const int DefValueInt = -1;

        public Car(string model, Engine engine, double weght, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weght;
            this.Color = color;
        }

        public Car(string model, Engine engine, double weght)
            : this(model, engine, weght, DefValueString)
        {            
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine, DefValueInt, color)
        {
        }

        public Car(string model, Engine engine)
            : this(model, engine, DefValueInt, DefValueString)
        {
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public double  Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Model}:");
            sb.AppendLine(Engine.ToString());

            sb.AppendLine(this.Weight == -1
                ? $"    Weight: n/a"
                : $"  Weight: {this.Weight}");

            sb.Append($"  Color: {this.Color}");

            return sb.ToString();
        }
    }
}

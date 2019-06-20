
namespace RawData
{
    public class Tire
    {
        private double presure;
        private int age;

        public Tire(int age, double presure)
        {
            this.Age = age;
            this.Presure = presure;
        }

        public double Presure
        {
            get { return presure; }
            set { presure = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
    }
}

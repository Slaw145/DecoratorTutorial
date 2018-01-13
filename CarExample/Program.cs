using System;

namespace CarsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mercedes = new Mercedes();

            mercedes = new RadioDecorator(mercedes);

            Console.WriteLine("The cost of a car with radio: " + mercedes.CostCar());

            Console.ReadKey();
        }
    }
}

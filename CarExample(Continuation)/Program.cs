using System;

namespace CarsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car fiat = new Fiat();

            fiat = new ACAndNewestEngineModelDecorator(fiat);

            Console.WriteLine("The cost of a car with air conditioning and a newer engine: " + fiat.CostCar());
            Console.WriteLine("The name of the newer engine model: " + fiat.TypeEngine());

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CarsExample
{
    public abstract class CarDecorator : Car
    {
        protected Car _car;

        public CarDecorator(Car car)
        {
            _car = car;
        }

        public override string ColorCar()
        {
            return _car.ColorCar();
        }

        public override double CostCar()
        {
            return _car.CostCar();
        }

        public override string TypeEngine()
        {
            return _car.TypeEngine();
        }
    }
}

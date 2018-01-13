using System;
using System.Collections.Generic;
using System.Text;

namespace CarsExample
{
    public class RadioDecorator : CarDecorator
    {
        public RadioDecorator(Car car)
        : base(car) { }

        public override string ColorCar()
        {
            return base.ColorCar();
        }

        public override double CostCar()
        {
            return base.CostCar() + 1232.32;
        }

        public override string TypeEngine()
        {
            return base.TypeEngine();
        }
    }
}

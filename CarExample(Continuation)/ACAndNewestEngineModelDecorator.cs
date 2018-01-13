using System;
using System.Collections.Generic;
using System.Text;

namespace CarsExample
{
    public class ACAndNewestEngineModelDecorator : CarDecorator
    {
        public ACAndNewestEngineModelDecorator(Car car)
        : base(car) { }

        public override string ColorCar()
        {
            return base.ColorCar();
        }

        public override double CostCar()
        {
            return base.CostCar() + 12332.32;
        }

        public override string TypeEngine()
        {
            return base.TypeEngine() + "a7c";
        }
    }
}

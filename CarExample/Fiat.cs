using System;
using System.Collections.Generic;
using System.Text;

namespace CarsExample
{
    class Fiat : Car
    {
        public override string ColorCar()
        {
            return "white";
        }

        public override double CostCar()
        {
            return 10000.32;
        }

        public override string TypeEngine()
        {
            return "engine-v3";
        }
    }
}

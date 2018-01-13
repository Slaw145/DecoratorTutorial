using System;
using System.Collections.Generic;
using System.Text;

namespace CarsExample
{
    class Golf : Car
    {
        public override string ColorCar()
        {
            return "black";
        }

        public override double CostCar()
        {
            return 23450.32;
        }

        public override string TypeEngine()
        {
            return "engine-v7";
        }
    }
}

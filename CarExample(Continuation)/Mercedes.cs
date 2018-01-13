using System;
using System.Collections.Generic;
using System.Text;

namespace CarsExample
{
    class Mercedes : Car
    {
        public override string ColorCar()
        {
            return "Green";
        }

        public override double CostCar()
        {
            return 36750.52;
        }

        public override string TypeEngine()
        {
            return "engine-v3e5";
        }
    }
}

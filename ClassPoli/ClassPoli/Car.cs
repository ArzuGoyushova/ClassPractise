using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPoli
{
    internal class Car: Vehicle
    {
        protected string Model="French";
        public readonly string Color ;

        public Car()
        {
            Color = "White";
        }
        public string CarModel()
        {
            return $"{Model} {Brand}"; //protected olsa da ishleyir, Brand publicdi
        }
    }
}

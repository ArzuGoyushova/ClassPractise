using System;
using System.Collections.Generic;
using System.Text;

namespace CelsiusToKelvin
{
    public class Celsius
    {
        public int Degree { get; }
        public Celsius(int degree)
        {
            Degree = degree;
        }

        public static implicit operator Celsius(Kelvin kelvin)
        {
            return new Celsius(kelvin.Degree - 273);
        }
    }
}

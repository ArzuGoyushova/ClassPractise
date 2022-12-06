using System;

namespace CelsiusToKelvin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kelvin kelvin = new Kelvin();
            kelvin.Degree = 295;
            Celsius celsius = kelvin;
            Console.WriteLine(celsius.Degree);
        }
    }
}

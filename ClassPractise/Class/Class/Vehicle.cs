using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    internal class Vehicle
    {
        public string brand;

        public Vehicle()
        {
            brand = "Ford";
        }
        public void Honk()
        {
            Console.WriteLine("Tuut tuut");
        }
    }
}

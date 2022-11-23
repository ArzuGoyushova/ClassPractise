using System;
using System.Collections.Generic;
using System.Text;

namespace SolarSystem
{
    internal class Earth : ISolarSystem, IUniverse
    {
        public void Expand()
        {
            Console.WriteLine("Universe is expanding non-stop.");
        }

        public void OurUniverse()
        {
            Console.WriteLine("Our universe is 1 in a million.");
        }

        public void Satelitte()
        {
            Console.WriteLine("Earth's satellite is the Moon.");
        }

        public void Spinning()
        {
            Console.WriteLine("All planets, including Earth are spinning around the Sun.");
        }

    }
}

using System;

namespace SolarSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Earth earth = new Earth();
            earth.OurUniverse();
            earth.Expand();
            earth.Satelitte();
            earth.Spinning();
        }
    }
}

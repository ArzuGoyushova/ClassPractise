using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractise.PaintService
{
    public class Paint : IPaint
    {
        public void PaintWalls(string color)
        {
            Console.WriteLine($"Walls are painted in {color}.");
        }
    }
}

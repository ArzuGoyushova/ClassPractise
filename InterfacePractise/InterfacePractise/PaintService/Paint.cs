using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractise.PaintService
{
    public class Paint : IPaint, IDesign
    {
        public void PaintWalls(string color)
        {
            Console.WriteLine($"Walls are painted in {color}.");
        }
        public string AmountOfPaint(int amount)
        {
            return $"We will need {amount} gallon.";
        }

        public string Mixed(string color1, string color2, string color3)
        {
            return $"We can mix {color1} and {color2} to get {color3}.";
        }

        public void Pattern(string pattern)
        {
            Console.WriteLine($"We can use {pattern} as a pattern to design.");
        }
    }
}

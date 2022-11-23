using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractise.PaintService
{
    public interface IPaint
    {
        void PaintWalls(string color);
        string AmountOfPaint(int amount);
        string Mixed(string color1, string color2, string color3);
    }
}

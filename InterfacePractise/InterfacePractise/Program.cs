using InterfacePractise.PaintService;
using System;

namespace InterfacePractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paint paint = new Paint();
            paint.PaintWalls("purple");
            Console.WriteLine(paint.AmountOfPaint(200));
            Console.WriteLine(paint.Mixed("blue", "red", "purple"));
            paint.Pattern("stripes");
        }
    }
}

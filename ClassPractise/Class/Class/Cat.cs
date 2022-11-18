using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    internal class Cat : Animals
    {
        public string Furr;

        public Cat(int height=255) : base(height)
        {
            height = 25;
        }

        public void Meow()
        {
            Console.WriteLine("They meow a lot.");
        }
    }
}

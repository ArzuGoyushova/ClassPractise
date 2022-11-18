using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    internal class Dog: Animals
    {
        public int Ears;

        public Dog(int height) : base(height)
        {

        }
        public void Bark()
        {
            Console.WriteLine("They bark a lot.");
        }
    }
}

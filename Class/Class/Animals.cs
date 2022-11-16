using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    internal class Animals
    {
        public string Name;
        public string Breed;
        public int Paws;
        public int Height;

        public Animals(int height)
        {
            Height = height;
        }
        public void Run()
        {
            Console.WriteLine("They run around a lot.");
        }
    }
}

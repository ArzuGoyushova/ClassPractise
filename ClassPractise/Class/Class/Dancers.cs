using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    internal class Dancers
    {
        public string Name;
        public string Surname;
        public int Age;
        public string Type;

        public Dancers()
        {
            Console.WriteLine("anyways");
        }
        public Dancers(string name, string surname)

        {
            Name = name;
            Surname = surname;
            Console.WriteLine($"{Name} did ChaCha");
        }
        public string Salsa()
        {
            return $"{Name} did Salsa too!";
        }
    }
}

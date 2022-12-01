using System;

namespace Lab1201
{

    internal class Program
    {
        public enum Seasons { Winter=1, Spring, Summer, Autumn};
        static void Main(string[] args)
        {
            //int number = 4;
            //Console.WriteLine(number.Factorial());

            //User user = new User();
            //user.Name = "Arzu";
            //user.Print();

            foreach (var item in Enum.GetValues(typeof(Seasons)))
            {
                Console.WriteLine(item);
            }
        }
    }
}

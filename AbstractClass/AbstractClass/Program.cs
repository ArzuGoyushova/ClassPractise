using Microsoft.VisualBasic;
using System;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GreatWallofChina wall = new GreatWallofChina();
            wall.Built();
            wall.History();
            wall.Damaged();

            TajMahal tajMahal = new TajMahal();
            tajMahal.Built();
            tajMahal.History();
            //tajMahal.year = 1632;
            Console.WriteLine($"Age: {tajMahal.Age(tajMahal.year)}");
            
            Colosseum colosseum = new Colosseum();
            colosseum.Built();
            colosseum.History();
            Console.WriteLine($"Age: {colosseum.Age(colosseum.year)}");


            //Architecture[] arr = {tajMahal, colosseum};
            //foreach (var item in arr)
            //{
            //    item.Built();
            //    item.Damaged();
            //}

        }
    }

    abstract class Architecture
    {
        public int Age(int year)
        {
            return 2022 - year;
        }
        public abstract void Built();
        public virtual void Damaged()
        {
            Console.WriteLine("Time damaged them naturally.");
        }
    }

    abstract class Miracles : Architecture
    {
        public abstract void History();
    }
    class GreatWallofChina : Miracles
    {
        public override void Built()
        {
            Console.WriteLine("China Wall was built a long time ago.");
        }

        public override void History()
        {
            Console.WriteLine("China Wall has a history.");
        }
    }

    class TajMahal : Miracles
    {
        public int year=1632;
        public override void Built()
        {
            Console.WriteLine("Taj Mahal was built a long time ago.");
        }

        public override void History()
        {
            Console.WriteLine("Taj Mahal has a history.");
        }       
    }

    class Colosseum : Miracles
    {
        public int year = -72;
        public override void Built()
        {
            Console.WriteLine("Colosseum was built a long time ago.");
        }

        public override void History()
        {
            Console.WriteLine("Colosseum has a history.");
        }
    }
}

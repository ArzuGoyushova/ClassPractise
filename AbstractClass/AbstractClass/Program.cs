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
            
            Colosseum colosseum = new Colosseum();
            colosseum.Built();
            colosseum.History();
            colosseum = new Colosseum();

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

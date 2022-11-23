using System;

namespace AbstractChineseDramas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TheUntamed mdzs = new TheUntamed();
            mdzs.year = 2019;
            mdzs.Filmed();
            mdzs.Type("Historical");
            mdzs.Info("The Untamed");
            mdzs.Year(mdzs.year);

            TGCF tgcf = new TGCF();
            tgcf.Filmed();
            tgcf.Type("Fantasy");
            tgcf.Info("Heaven officials's blessing");
            tgcf.Year(tgcf.year);
        }
    }

    abstract class ChineseDramas
    {
        public abstract void Filmed();
        public virtual void Type(string type)
        {
            Console.WriteLine($"{type} is one of the popular type of drama.");
        }   
    }
    abstract class MartialArts : ChineseDramas
    {
        public virtual void Year(int year)
        {
            Console.WriteLine($"Released in {year}.");
        }
        public virtual void Info( string name)
        {
            Console.WriteLine("Martial Art is one of the traditional symbols of China, " +
                $"there are a lo of dramas based on this topic. {name} is one of them.");
        }
    }

    class TheUntamed : MartialArts
    {
        public int year { get; set; }
        public override void Filmed()
        {
            Console.WriteLine("The Untamed is filmed in China.");
        }
    }
    class TGCF : MartialArts
    {
        public int year = 2022;
        public override void Filmed()
        {
            Console.WriteLine("TGCF is filmed in China.");
        }
    }
}

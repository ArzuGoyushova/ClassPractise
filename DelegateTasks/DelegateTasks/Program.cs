using System;

namespace DelegateTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spell(letter => Console.WriteLine(letter), "Spell It");
            Sum((a, b) => a*b);
            Dollar(azn => azn * 1.7);
            LastSong((s, l) => s + l);
            DprIan(sentence => Console.WriteLine(sentence.ToLower()),"You're So Beautiful");
        }

        public static void Spell(Action<char> function, string spelling)
        {
            char[] arr=spelling.ToCharArray();
             for (int i=0; i<arr.Length; i++)
            {
                function(arr[i]);
            }
        }

        public static void Sum(Func<int,int,double> function)
        {
            int n = 12;
            int m = 20;
            Console.WriteLine(function(n, m));
        }

        public static void Dollar(Func<double,double> convert)
        {
            double azn = 200;
            double usd = convert(azn);
            Console.WriteLine(usd);
        }

        public static void LastSong(Func<string,string,string> print)
        {
            string song1="Christmas Tree";
            string lastSong = "Last Song is ";
            Console.WriteLine(print(lastSong,song1));
        }
        public static void DprIan(Action<string> wow, string message)
        {
            
            wow(message);
        }
    }
}

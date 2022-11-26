using System;
using System.Diagnostics.Tracing;

namespace StaticEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 4;
            //Console.WriteLine(num.Factorial());

            //string sentence = "Cause I I I know what you like boy.";
            //Console.WriteLine(sentence.Count("I"));

            Console.WriteLine("Add a sentence: ");
            string sentence=Console.ReadLine();
            Console.Write("The word you search: ");
            string search = Console.ReadLine();
            Console.WriteLine("Count = "+sentence.Count(search));
        }
    }
}

using System;
using System.Diagnostics.Tracing;

namespace StaticEnum
{
    internal class Program
    {
        public enum Weekdays { Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday };
        static void Main(string[] args)
        {
            //int num = 4;
            //Console.WriteLine(num.Factorial());

            //string sentence = "Cause I I I know what you like boy.";
            //Console.WriteLine(sentence.Count("I"));

            //Console.WriteLine("Add a sentence: ");
            //string sentence=Console.ReadLine();
            //Console.Write("The word you search: ");
            ////string search = Console.ReadLine();
            //Console.WriteLine("Count = "+sentence.Count(@"[a]"));

            int day = 3;
            switch (day)
            {

                case (int)Weekdays.Monday:
                    Console.WriteLine("1ci gun");
                    break;
                case (int)Weekdays.Tuesday:
                    Console.WriteLine("2ci gun");
                    break;
                case (int)Weekdays.Wednesday:
                    Console.WriteLine("3cu gun");
                    break;
                case (int)Weekdays.Thursday:
                    Console.WriteLine("4cu gun");
                    break;
                default:
                    break;
            }
        }
    }
}

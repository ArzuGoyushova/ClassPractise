using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using ClassLibrary1;

namespace PractiseOverall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name="Arzu Goyushova";
            //Console.WriteLine(Reversed(name));

            //Calc(4,2);
            Console.WriteLine(RegexCheck("her ne45yse 123"));
        }

        #region ReversedString
        //static string Reversed(string name)
        //{
        //  StringBuilder sb = new StringBuilder();
        //    for (int i = name.Length - 1; i >= 0; i--)
        //    {
        //        sb.Append(name[i]);
        //    }
        //    return sb.ToString();
        //}
        #endregion

        #region Math
        //static void Calc (int x, int y)
        //{
        //    int min=Math.Min(x,y);
        //    int max=Math.Max(x,y);
        //    int abs=Math.Abs(x);
        //    double pow = Math.Pow(x,y);
        //    double sqrt = Math.Sqrt(x);
        //    Console.WriteLine(pow + sqrt);
        //}
        #endregion

        #region Regex
        static int RegexCheck(string sentence)
        {
            return Regex.Matches(sentence, @"\d+").Count;
            //return Regex.IsMatch(sentence, @"\d");
        }

        #endregion
    }
}

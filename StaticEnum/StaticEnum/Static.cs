using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StaticEnum
{
    static class Static
    {
        public static int Factorial(this int num)
        {
            int fact = 1;
            for (int i = num; i > 1; i--)
            {
                fact *= i;
            }
            return fact;
        }

        //public static int Count(this string sentence, string search)
        //{
        //    int count = 0;
        //    string[] words = sentence.Split(' ');
        //    foreach(string item in words)
        //    {
        //        if (item == search)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
        //public static int Count(this string sentence, string search)
        //{
        //   return Regex.Matches(sentence, search).Count;
        //}


    }
}

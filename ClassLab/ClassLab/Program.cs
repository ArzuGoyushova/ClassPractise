using System;
using System.Globalization;

namespace ClassLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayClass arrObj = new ArrayClass();
            //arrObj.Numbers =new int [] {1,2,3,4};
            //arrObj.ArrMethod();           

            //ArrayClass arrObj = new ArrayClass();
            //int [,] nums = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 15 } };
            //arrObj.Dioganal(nums);

            ArrayClass subs = new ArrayClass();
            Console.WriteLine(subs.Substring(" P515 "));
        }
    }
}

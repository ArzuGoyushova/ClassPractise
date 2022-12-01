using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1201
{
    static class Extension
    {
        //public static int Factorial(this int number)
        //{
        //    int fact = 1;
        //    for (int i = 1; i <= number; i++)
        //    {
        //        fact *= i;
        //    }
        //    return fact;
        //}

        public static void Print(this User user)
        {
            Console.WriteLine(user.Name);
        }
    }
}

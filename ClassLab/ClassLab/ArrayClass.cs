using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ClassLab
{

    internal class ArrayClass
    {
        //public int[] Numbers;
        //public void ArrMethod ()
        //{
        //    foreach (int item in Numbers)
        //    {
        //        Console.WriteLine($"{item}"); 
        //    }
            
        //}
        
        //public void Dioganal (int[,] array)
        //{
        //    int sum1 = 0;
        //    int sum2 = 0;
        //    int diff = 0;
        //    int [,] array2=new int[3,3];
        //    for (int i=0; i < array.GetLength(0); i++)
        //    {
        //        sum1 = sum1 + array[i, i];
        //    }
            
        //    int j=array.GetLength(0)-1;
        //    for (int i=0; i < array.GetLength(0); i++)
        //    {               
        //        sum2=sum2+array[i,j];
        //        j--;
        //    }
        //    diff = sum1 - sum2;
        //    Console.WriteLine(sum1);
        //    Console.WriteLine(sum2); 
        //    Console.WriteLine(diff);
        //}

        public string Substring (string word)
        {
            string word2 = word.Substring();
            return word2;
        }
    }
}

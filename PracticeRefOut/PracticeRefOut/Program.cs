using System;

namespace PracticeRefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=10;
            int b=20;
            //Ref-de yuxarida mutleq a=10; b=20; olmalidi.
            check(ref a, ref b);
            //Out-da mutleq metoddaki c=12;z=22 olmalidi, yuxarida tekce a,b olsa da olar.
            checkout(out a, out b);
            //eger ref ve out olmasa cavab tekce 30du. ref ve out yazanda girir metoda hesablayir qaytarir yuxari cavaba.
            Console.WriteLine(a+b);
        }
        static void check (ref int x,ref int y)
        {
           // x = 5; y = 2;
            x = x + y;
            
        }

        static void checkout (out int c, out int z)
        {
            c = 12; z = 22;
            c = c + z;
        }
    }
}

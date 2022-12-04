using System;
using System.Collections.Immutable;
using System.Linq;

namespace PersonArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Arzu", "Goyushova", 26, 10);
            Person person2 = new Person("Taehyung", "Kim", 30, 1000000);
            Person person3 = new Person("Narmin", "Ismayilova", 19, 1000000000);
            Person[] arr = { person1, person2, person3 };


            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}

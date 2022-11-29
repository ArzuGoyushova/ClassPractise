using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ClassLibrary1;

namespace PractiseOverall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name="Arzu Goyushova";
            Console.WriteLine(Reversed(name));
           

        }
        static string Reversed(string name)
        {
          StringBuilder sb = new StringBuilder();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                sb.Append(name[i]);
            }
            return sb.ToString();
        }
    }
}

using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace PracticeStaticEnum
{
    public enum Members {Taehyung=1, Jungkook, Hobi };
    internal class Program
    {
        static void Main(string[] args)
        {
            B check = new B();
            
            B.name = "aci";
            Console.WriteLine(B.name);

            string name = "arzuezizicigez";
            Console.WriteLine(name.Names("z"));

            C cc = new C();
            cc.MyMembers=Members.Taehyung;
            
            Members first = Members.Taehyung;

            double result;
            result = Math.Pow(2, 5);
            Console.WriteLine(result);
        }
    }
    class A
    {
        public virtual void MB()
        {
            Console.WriteLine("method");
        }
    }
    class B : A
    {
        
        public static string name;
        sealed public override void MB()
        {
            Console.WriteLine("aci");
        }
    }
    sealed class C : B
    {
        public Members MyMembers { get; set; }
    }
    //class Z : C olmur
    //{

    //}
    static class Z
    {
        static string surname="a";

    }

    static class Ext
    {
        public static bool Names(this string name, string pattern)
        {
            return Regex.IsMatch(name, pattern);
        }
    }
}

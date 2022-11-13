using System;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Request req1 = new Request();
            req1.Name = "Arzu";
            req1.Surname = "Goyushova";
            req1.PhoneNumber = "0708963496";
            req1.Category = "Full-Stack Programming";
            req1.Notes = "No comment";

            
            Console.WriteLine(req1.Credentials());
            Console.WriteLine(req1.PhNumber());
            Console.WriteLine(req1.Cat());
            Console.WriteLine(req1.Note());

        }



    }
}

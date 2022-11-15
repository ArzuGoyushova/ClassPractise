using System;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Request req1 = new Request();
            //req1.Name = "Arzu";
            //req1.Surname = "Goyushova";
            //req1.PhoneNumber = "0708963496";
            //req1.Category = "Full-Stack Programming";
            //req1.Notes = "No comment";


            //Console.WriteLine(req1.Credentials());
            //Console.WriteLine(req1.PhNumber());
            //Console.WriteLine(req1.Cat());
            //Console.WriteLine(req1.Note());

            //Car myCar = new Car();
            ////Console.WriteLine(myCar.color);
            ////Console.WriteLine(myCar.maxSpeed); or

            //myCar.color = "red";
            //myCar.maxSpeed = 240;
            //Console.WriteLine(myCar.color);
            //Console.WriteLine(myCar.maxSpeed);

            //Car Porsche = new Car();
            //Porsche.color = "red";
            //Porsche.Model = "Porsche";
            //Porsche.Year = 2022;
            //Console.WriteLine(Porsche.Year);

            //Car Maseratti = new Car();
            //Maseratti.color = "black";
            //Maseratti.Model = "Maseratti";
            //Console.WriteLine(Maseratti.color);
            //Maseratti.Message();

            //Console.Write("Enter max Porsche speed: ");
            //int Pspeed = int.Parse(Console.ReadLine());
            //Console.Write("Enter max Maseratti speed: ");
            //int Mspeed = int.Parse(Console.ReadLine());
            //Console.WriteLine(Porsche.Faster(Pspeed, Mspeed));

            //Car Mercedes = new Car("Mercedes X90");
            //Console.WriteLine(Mercedes.Model);

            //Car BMW = new Car("BMW S Class", "Black", 360);
            //Console.WriteLine($"Model: {BMW.Model}, Color: {BMW.Color}, Speed: {BMW.Speed}");

            Car Ford = new Car();
            Ford.Honk();

            
        }



    }
}

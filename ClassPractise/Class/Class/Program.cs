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

            //Car Ford = new Car();
            //Ford.Honk();

            //Cat cat = new Cat();
            //cat.Name = "Daisy";
            //cat.Paws = 4;
            //Console.WriteLine(cat.Paws);
            //cat.Furr = "Big";
            //cat.Meow();
            //Console.WriteLine(cat.Height);

            //Dog dog=new Dog(12);
            //dog.Run();
            //dog.Bark();
            //dog.Name = "jelly";
            //dog.Ears = 2;
            //Console.WriteLine(dog.Height);

            //Snake snake = new Snake("Popimi", "Uzundrazova");
            //snake.Name = "Gombulik";
            //snake.Age = 29;
            //Console.WriteLine($"{snake.Name} + {snake.Age} + {snake.Surname}");

            Dancers dancer1 = new Dancers("Arzu", "Cicili");
            dancer1.Age = 26;
            dancer1.Type = "Latin";
            Console.WriteLine(dancer1.Name);
            Console.WriteLine(dancer1.Surname);
            Console.WriteLine(dancer1.Age);
            Console.WriteLine(dancer1.Type);
            Console.WriteLine(dancer1.Salsa());

        }



    }
}

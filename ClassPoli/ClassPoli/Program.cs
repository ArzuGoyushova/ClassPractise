using System;

namespace ClassPoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            ////car._name vehicle-da private oldugundan tanimir
            //car.Brand = "Maseratti";
            ////car.Model Car-da protected oldugundan tanimir
            //car.Speed = 240;
            //Console.WriteLine(car.CarModel());
            //car.MinSpeed();
            ////car.Gasoline = "Diselle"; private set olduguna gore olmur
            //Console.WriteLine(car.Gasoline);
            Person person = new Person();
            person.Name = "Arzum";
            Console.WriteLine(person.Name);
        }
    }
    

    
}

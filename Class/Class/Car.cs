using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    internal class Car
    {
        public string Model;
        public Car(string modelName)
        {
            Model = modelName;
        }
        //public string color = "red";
        //public int maxSpeed = 240; or 

        public string color;
        public int maxSpeed;
        public int Year;

        public void Message()
        {
            Console.WriteLine("Porsche or Maseratti");
        }

        public string Faster (int Pspeed, int Mspeed)
        {
            if (Pspeed > Mspeed)
            {
                return "Porsche is faster.";
            }
            else
                return "Maseratti is faster.";
        }
    }
}

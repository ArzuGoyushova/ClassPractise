using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPoli
{
    internal class Vehicle
    {
        private string _name;
        public string Brand { get; set; }
        internal int Speed;
        public string Gasoline 
        { 
            get
            {
                return Gasoline;
            } 
            private set
            {
                Gasoline = value;
                value = "Oil";
                
            } 
        }



        public void MinSpeed()
        {
            Console.WriteLine(Speed);

        }
    }
}

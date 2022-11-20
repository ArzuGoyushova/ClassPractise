using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPoli
{
    internal class Person
    {

        private string _firstname;
        private string _lastname;
        private string[] array;
        public string Fullname;

        public string FullName
        {
            get
            {
                return _firstname;
            }
            set
            {
                Fullname = value;
                array = value.Split(" ");
                _firstname = array[0];
                _lastname = array[1];
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >= 5)
                {
                    _name = value;
                    Console.WriteLine("Name is set.");
                }
                else
                {
                    Console.WriteLine("Name is short.");
                }
            }
        }
        
    }
}

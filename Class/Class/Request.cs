using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    internal class Request
    {
        public string Name;
        public string Surname;
        public string PhoneNumber;
        public string Category;
        public string Notes;
        


        public Request()
        {
            Console.WriteLine("working");
        }
        public Request(string name, string surname, string phone, string category, string notes)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phone;
            Category = category;
            Notes = notes;
        }
       

        public string Credentials()
        {
            return $"Ad: {Name} , soyad: {Surname}";
        }

        public string PhNumber()
        {
            return $"Nomre {PhoneNumber}";
        }

        public string Cat()
        {
            return $"Category: {Category}";
        }

        public string Note()
        {
            return $"Notes: {Notes}";
        }



    }
}

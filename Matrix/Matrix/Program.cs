using System;
using System.Collections.Generic;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Ayan", 26);
            Person person2 = new Person("Narmin", 25);
            Person person3 = new Person("Sevinc", 19);

            List<Person> persons = new List<Person>();
            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);
            foreach(Person person in persons)
            {
                if (person.Name.ToUpper().Contains('A')&&(person.Age > 20))
                {
                    Console.WriteLine(person.Name);
                }
            }

            Queue<Person> list = new Queue<Person>();
            list.Enqueue(person1);
            list.Enqueue(person2);
            list.Enqueue(person3);
            foreach (Person person in list)
            {
               list.Peek();
            }

        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age; 
            }


            class Lists
            {
                Queue<Person> list = new Queue<Person>();
                //list.Enqueue(person1);
                //Console.WriteLine(list.Peek());

            }
        }
    }
}
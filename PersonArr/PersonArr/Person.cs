using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PersonArr
{
    public class Person : IComparable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public DateTime Birthday { get; set; }
        public Person(string name, string surname, int age, int salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
        }
        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }
        public static bool operator >(Person p1, Person p2)
        {
            return p1.Age > p2.Age;
        }

        public int CompareTo(object obj)
        {
            return this.Age.CompareTo(((Person)obj).Age);
            
        }

      
    }
}

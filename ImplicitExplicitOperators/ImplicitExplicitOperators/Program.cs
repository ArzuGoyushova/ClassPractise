using System;

namespace ImplicitExplicitOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manat manat = new Manat(340);
            //Dollar dollar = manat;
            //Console.WriteLine(dollar.Usd);
            //Dollar dollar = (Dollar)manat;
            //Console.WriteLine(dollar.Usd);

            //Angel angel = new Angel(752);
            //Person person = (Person)angel;
            //Console.WriteLine(person.Age);

            Person person1 = new Person("Arzu", "Goyushova", 26, 3000);
            person1.BirthDay=DateTime.Now.AddYears(-26);
           // Console.WriteLine(person1.BirthDay);
            Person person2 = new Person("Sevinc", "Mehdi", 28, 4000);
            Person person3 = new Person("Manash", "Mohteshem", 3, 9999999);

            //Console.WriteLine(person1>person2);
            Person[] arr = { person1, person2 };
            Array.Sort(arr);
            foreach(var item in arr)
            {
                Console.WriteLine(item.Name);
            }
            
        }
    }

    class Dollar
    {
        public double Usd { get; set; }
        public Dollar(double usd)
        {
            Usd = usd;
        }
        public static implicit operator Dollar(Manat manat)
        {
            return new Dollar(manat.Azn / 1.7);
        }
    }

    class Manat
    {
        public double Azn { get; set; }
        public Manat(double azn)
        {
            Azn = azn;
        }      
    }
    class Personn
    {
        public int Age { get; set; }
        public Personn(int age)
        {
            Age = age;
        }
        public static explicit operator Personn (Angel angel)
        {
            return new Personn(angel.Age - 300);
        }
    }
    class Angel
    {
        public int Age { get; set; }
        public Angel(int age)
        {
            Age = age;
        }
    }

    class Person : IComparable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public Person(string name, string surname, int age, int salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
        }
        public DateTime BirthDay { get; set; }
        public static bool operator >(Person p1, Person p2)
        {
            return p1.BirthDay > p2.BirthDay;
        }
        public static bool operator <(Person p1, Person p2)
        {
            return p1.BirthDay < p2.BirthDay;
        }

        public int CompareTo(object obj)
        {
            return ((Person)obj).Age.CompareTo(this.Age);
        }
    }
}

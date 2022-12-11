using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Delegate
{
    internal class Program
    {
        public delegate bool Check(int num);
        static void Main(string[] args)
        {
            //Console.WriteLine(Sum(m=>m>1,1,2,3,4,5));
            //Action<string> function = (s) => Console.WriteLine("message");

            Average();
            
        }

        public static void Average()
        {
            Employee employee1 = new Employee();
            employee1.Name = "Taehyung";
            employee1.Surname = "Kim";
            employee1.Age = 26;
            employee1.Salary = 2000;

            Employee employee2 = new Employee();
            employee2.Name = "Namjoon";
            employee2.Surname = "Kim";
            employee2.Age = 55;
            employee2.Salary = 3000;

            Employee employee3 = new Employee();
            employee3.Name = "Jin";
            employee3.Surname = "Kim";
            employee3.Age = 30;
            employee3.Salary = 5000;

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);

            List<Employee> Age= employeeList.FindAll(em => em.Age > 20 && em.Age < 40);
            Console.WriteLine(Age.Average(em=>em.Salary));



            //double ave = 0;
            //double sum = 0;
            //int count = 0;
            //foreach(Employee employee in employeeList.FindAll(em => em.Age > 20 && em.Age < 40))
            //{
            //        sum += employee.Salary;
            //        count++;
            //        ave = sum / count;
            //}
            //return ave;
        }
        
        public class Employee
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int  Age { get; set; }
            public double Salary { get; set; }
        }

    }
}

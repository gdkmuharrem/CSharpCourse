using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3]
            {
                new Customer{FirstName = "Muharrem"},
                new Student{FirstName = "Ahmet"},
                new Person{FirstName = "Mehmet"}
            };
            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Departmant { get; set; }
    }
}

//NOT:
/*
 Interface ile Inheritance farkları:
interface newlenemez tek başına fakat inheritance normal bir sınıf olarak devam eder.
inheritancede babadan çocuğa miras gibi olduğu için her cocugun 1 tane babası olabilir yani bir class birden fazla miras alamaz.
Fakat interface olarak sınırsızdır.
 
 */

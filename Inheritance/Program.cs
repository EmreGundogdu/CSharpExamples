using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.City = "Eses";

            Person[] persons = new Person[]
            {
                new Customer{ FirstName="Emre"}, new Student{ FirstName="Yaren"}, new Person{FirstName="Derin"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string City { get; set; }
    }
    class Student:Person
    {
        public string Department { get; set; }
    }
}

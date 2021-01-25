using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 2,
                FirstName="Yaren",
                LastName="Gndgd",
                Adress="Eses"
            
            };

            Student student = new Student
            {
                Id = 3,
                FirstName="Derin",
                LastName="Gndgd",
                Department="Bilişim"
            };
            personManager.Add(customer);
            personManager.Add(student);
            

        }
        interface IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Adress { get; set; }

        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}

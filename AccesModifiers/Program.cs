using System;
using AccesModifiers;

namespace AccesModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Customer
    {
        protected int id;
        public void Save()
        {
            int id;
            
        }
        public void Delete()
        {
            
        }
    }
    class Student:Customer
    {
        public void Save2()
        {
            

        }
    }

    public class Course
    {
        public string Name { get; set; }

    }
}

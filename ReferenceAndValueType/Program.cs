using System;
using System.Data;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);


            string[] cities = new string[] { "Ankara", "Adana" };
            string[] cities2 = new string[] { "Bursa", "Bolu" };
            cities2 = cities; //cities2'nin değeri cities'dir 
            cities[0] = "İstanbul";

            Console.WriteLine(cities2[0]);

            //DataTable dataTable;
            //DataTable dataTable1 = new DataTable();
            //dataTable = dataTable1;
        }
    }
}

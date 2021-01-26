using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[2] { "Ankara", "İstanbul" };
            cities = new string[3];
            //Console.WriteLine(cities[0]);


            ArrayList citiesList = new ArrayList();
            citiesList.Add("Eskişehir");
            citiesList.Add("Adana");

            
            citiesList.Add("İstanbul");
            citiesList.Add(1);
            citiesList.Add('E');

            foreach (var city in citiesList)
            {
                Console.WriteLine(city);
            }

        }
    }
}

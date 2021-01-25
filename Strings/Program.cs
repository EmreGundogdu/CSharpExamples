using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "Eskişehir";
            Console.WriteLine(city[0]);
            Console.WriteLine(city);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");
            string city2 = "İstanbul";
            string result = city + city2;
            Console.WriteLine(result);
            Console.WriteLine("-----------");


            Console.WriteLine(String.Format("{0} {1}",city,city2));


            string sentence = "My name is Emre";
            var result2 = sentence.Length;
            var result3 = sentence.Clone();
            sentence = "My name is Yaren";

            bool res = sentence.EndsWith("e");
            bool res2 = sentence.StartsWith("M");

            var res4 = sentence.IndexOf("name");
            var res5 = sentence.IndexOf(" ");
            var res6 = sentence.Insert(0, "Hello ");
            var res7 = sentence.Substring(3);
            var res8 = sentence.ToLower();
            var res9 = sentence.ToUpper();
            var res10 = sentence.Replace(" ","-");
            var res11 = sentence.Remove(2);
            var res12 = sentence.Remove(2,5);


            Console.WriteLine(res12);
        }

    }
}

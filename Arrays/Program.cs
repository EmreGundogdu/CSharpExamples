using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Emre";
            students[1] = "Talip";
            students[2] = "Ahmet";

            string[] students2 = new string[] {"Emre","Derin","Yaren" };

            string[] students3 = { "Emre", "Derin", "Yaren" };

            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","Balıkesir","İzmit"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                { "İzmir","Muğla","Manisa"}

            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**************");
            }

        }
    }
}

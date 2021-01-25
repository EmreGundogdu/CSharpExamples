using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types

            //Console.WriteLine("Hello World!");
            //Console.ReadLine();

            //INT
            int number1 = 10; //-2147483647 | 2147483647
            Console.WriteLine("Number1 is {0}",number1);

            //LONG
            long number2 = 2147483648984324234;
            Console.WriteLine("Number2 is " + number2);

            //SHORT
            short number3 = -32768;
            Console.WriteLine("Number3 is " + number3);

            //BYTE
            byte number4 = 0; //0-255
            Console.WriteLine("Number4 is " + number4);

            //BOOLEAN
            bool condition = false;

            //CHAR
            char chracter = 'A';
            Console.WriteLine((int)chracter); //Aski karşılığını aldık

            //DOUBLE
            double sayi = 10.5;
            Console.WriteLine(sayi);

            //Decimal
            decimal number6 = 10.4m;

            Console.WriteLine((int)days.Friday);

            //String
            string name = "Emre";
            Console.WriteLine(name);

            //Var
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine(number7);

        }
    }
    //ENUM
    enum days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}

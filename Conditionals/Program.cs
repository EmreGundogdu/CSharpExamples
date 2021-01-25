using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            //if (number == 10)
            //{
            //    Console.WriteLine("Sayı " + number + "'dur.");
            //}else if(number == 20)
            // {
            //    Console.WriteLine("Number is different");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10");
            //}

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break;
            //    case 11:
            //        Console.WriteLine("Number is 11");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;
            //}

            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("Number is between 0-100");
            //}else if(number>100 && number <= 200)
            //{
            //    Console.WriteLine("Number is bertween 101-200");
            //}
            //else if(number > 200 || number < 0 )
            //{
            //    Console.WriteLine("Number is less than 0 or greater than 200");
            //}

            int number95 = 95;
            if (number95 < 100)
            {
                if (number95 >= 90 && number95 < 95)
                {
                    Console.WriteLine("This method worked");
                }

            }
        }
    }
}

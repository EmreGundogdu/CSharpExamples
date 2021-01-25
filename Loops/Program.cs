using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("****************");
            for (int i = 100; i >= 0 ; i=i-2)
            {
                Console.WriteLine(i);
            }

            int number = 100;
            while (number>=0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}",number);

        }
    }
}

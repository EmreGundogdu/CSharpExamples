using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();

            var result = Add1(20, 40);
            //Console.WriteLine(result);



            //var result2 = Add2(40);


            //int number1 = 20;
            //int number2 = 100;
            //var result3 = Add3(out number1, number2);



            //Console.WriteLine(number1); burada 30 yazar çünkü ref ve out kullanırsak bu metoda göre aşağıdaki number1 belirlenir
            //ref - number1'i tanımlamak lazım yani parametre dışında değer vermek lazım

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,6));

            Console.WriteLine(Add4(2,3,4,5));


        }
        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add1(int number1, int number2) //int türünde sonuç döndürsün
        {
            var result = number1 + number2;
            return result;
        }
        //Default parametreli methods
        static int Add2(int x, int number3 = 10, int number4 = 20)
        {
            return number3 + number4;
        }
        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1,int number2,int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers) //params =  ile 2'li 3'lü 4'lü uzun uzun metodlar yazmak yerine istediğmiz kadar paramtre göndermemizi sağlıyor
        {
            return numbers.Sum(); //yazılan paramterelerin hepsini toplatır
        }

    }
}

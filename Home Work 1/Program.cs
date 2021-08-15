using System;

namespace Home_Work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool readable = true;

            Console.WriteLine("Введите первое число: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите второе число: ");
            string str2 = Console.ReadLine();

            int num1 = 0;
            int num2 = 0;
            double result;
            try
            {
                num1 = Convert.ToInt32(str1);
                num2 = Convert.ToInt32(str2);
            }
            catch (Exception)
            {
                Console.WriteLine("Введено неккоректное число");
                readable = false;
                
            }

            if (readable)
            {
                result = (num1 + num2)/2;
                Console.WriteLine("Среднее арифметическое = " + result);
            }

            Console.ReadKey();
        }
    }
}

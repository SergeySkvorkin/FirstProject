using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите сумму в тенге: ");
                string userEnteredString = Console.ReadLine();
                double userEnteredValue = 0.0;
                bool exception = false;
                try
                {
                    userEnteredValue = double.Parse(userEnteredString);

                }
                catch (Exception)
                {
                    Console.WriteLine("Введена некорректная сумма! ");
                    exception = true;
                }

                if (!exception)
                {
                double result = userEnteredValue * 0.0023;
                string formatedResult = result.ToString("F2");
                Console.WriteLine( userEnteredString + " тенге в долларах: " + formatedResult + " USD");
                }


                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}

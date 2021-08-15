using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Something else");

            int a;
            string v = Console.ReadLine();
            a = int.Parse(v);
            Console.WriteLine(v);
            while (a > 1) 
            {
                Console.WriteLine(a);
                a = a - 1;
            }
        }
    }
}

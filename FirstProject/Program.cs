using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Convertations Converting = new Convertations();
            int a = Converting.FromStringToInt32("1");
        }
    }
}

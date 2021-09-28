using System;

namespace BinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
        }
        static void start()
        {
            Console.WriteLine("enter num:");
            string op = Console.ReadLine();
            int opInt = int.Parse(op);
            if (opInt == 0)
            {
                start();
            }
            else
            {
                converter(opInt);
                Console.WriteLine();
                Console.WriteLine("---------------");
                start();
            }
        }
        static void converter(int n)
        {
            int temp = n % 2;
            if (n >= 2) converter(n / 2);
            Console.Write(temp);
        }
    }
}

using System;

namespace Nod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("НОД:");
            int a = 465;
            int b = 806;
            string s = $"a = {a}, b = {b}, NOD = {Calculate2(a, b)}";
            Console.WriteLine(s);
        }

        static int Calculate(int a, int b)
        {
            int ost = a % b;
            if (a % b == 0 ) return b;
            else return Calculate(b, b % ost);
        }

        static int Calculate2(int a, int b)
        {
            while (b != 0) b = a % (a = b);
            return a;
        }
    }
}

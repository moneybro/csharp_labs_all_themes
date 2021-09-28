using System;

namespace recurs
{
    class Program
    {
        static void Main(string[] args)
        {
            recurs(10);
        }

        static void recurs(int counter)
        {
            counter--;
            Console.WriteLine($"a:{counter}");
            if (counter !=0)
            {
                recurs(counter);
            }
            Console.WriteLine($"b:{counter}");
        }
    }
}

using System;

namespace _006_Anonim_method_with_args
{
    public delegate int MyDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            int summand1 = 1, summand2 = 2, sum = 0;
            MyDelegate myDelegate = delegate (int a, int b) { return a + b; };
            sum = myDelegate(summand1, summand2);
            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);
            Console.ReadKey();
        }
    }
}

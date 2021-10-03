using System;

namespace _008_Lyambds
{
    public delegate int MyDelegate(int a);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate;
            myDelegate = delegate (int x) { return x * 2; }; //лямбда метод
            myDelegate = (x) => { return x * 2; };           //лямбда оператор
            myDelegate = x => x * 2;                         //лямбда выражение

            int result = myDelegate(4);
            Console.WriteLine("result: {0}",result);
            Console.ReadKey();
        }
    }
}

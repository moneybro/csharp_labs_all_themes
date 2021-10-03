using System;

namespace _009_Lyambds_void
{
    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate;
            myDelegate = delegate { Console.WriteLine("hello1"); };         //лямбда метод
            myDelegate += () => { Console.WriteLine("hello2"); };           //лямбда оператор
            myDelegate += () => Console.WriteLine("hello3");                //лямбда выражение

            myDelegate();
            Console.ReadKey();
        }
    }
}

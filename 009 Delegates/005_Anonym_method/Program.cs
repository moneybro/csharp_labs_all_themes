using System;

namespace _005_Anonym_method
{
    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = delegate { Console.WriteLine("hello w"); };
            //MyDelegate myDelegate = new MyDelegate(delegate { Console.WriteLine("hello w"); }); //полная запись предыдущей строки

            myDelegate();
            Console.ReadKey();
        }
    }
}

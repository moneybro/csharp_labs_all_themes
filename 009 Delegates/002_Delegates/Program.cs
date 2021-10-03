using System;

namespace _002_Delegates
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Строку вывел метод сообщеный с делегатом");
        }
    }
    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            MyDelegate myDelegate = new MyDelegate(instance.Method);
            myDelegate.Invoke();
            myDelegate();
        }
    }
}

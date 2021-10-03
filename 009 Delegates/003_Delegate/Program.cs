using System;

namespace _003_Delegates
{
    class MyClass
    {
        public string Method(string name)
        {
            return "hello " + name;
        }
    }

    public delegate string MyDelegate(string name2);
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            MyDelegate myDelegate = new MyDelegate(instance.Method);
            string greeting = myDelegate.Invoke("bob"); // вызываем метод сообщенный с делегатом
            Console.WriteLine(greeting);
            greeting = myDelegate("rob"); // вызываем метод сообщенный с делегатом
            Console.WriteLine(greeting);
        }
    }
}

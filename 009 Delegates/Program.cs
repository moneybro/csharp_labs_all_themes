using System;

namespace Delegates
{
    static class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("Строку вывел метод сообщеный с делегатом");
        }
    }
    public delegate void MyDelegate(); // создаем класс делегата, который ничего не принимает (нет параметров в передаваемом методе delegatedMethod(__пустота__) ) и делегат ничего не возвращает void
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(MyClass.Method);
            myDelegate.Invoke(); // вызов метода сообщенного с делегатом invoke - вызов
            myDelegate(); // другой способ вызова метода сообщенного с делегатом

        }
    }
}

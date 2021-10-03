using System;

// комбинированные или групповые делегаты - это делегаты, которые содержат в себе более одного метода

namespace _004_Group_Delegates
{
    public delegate void MyDelegate();
    class Program
    {
        public static void Method1()
        {
            Console.WriteLine("method1");
        }
        public static void Method2()
        {
            Console.WriteLine("method2");
        }
        public static void Method3()
        {
            Console.WriteLine("method3");
        }
        static void Main(string[] args)
        {
            MyDelegate myDelegate = null;
            MyDelegate myDelegate1 = new MyDelegate(Method1);
            MyDelegate myDelegate2 = new MyDelegate(Method2);
            MyDelegate myDelegate3 = new MyDelegate(Method3);

            // комбинируем делегаты
            myDelegate = myDelegate1 + myDelegate2 + myDelegate3;

            

            Console.WriteLine("введите число от 1 до 7");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    myDelegate1.Invoke();
                    break;
                case "2":
                    myDelegate2.Invoke();
                    break;
                case "3":
                    myDelegate3(); // можно и с методом Invoke, но так мне больше нравится
                    break;
                case "4":
                    myDelegate -= myDelegate2;
                    myDelegate();
                    break;
                case "5":
                    myDelegate -= myDelegate1;
                    myDelegate();
                    break;
                case "6":
                    myDelegate -= Method3; // открепляем непосредственно метод
                    myDelegate();
                    break;
                default:
                    break;
            }
            
            // урок 9 45:33
        }
    }
}

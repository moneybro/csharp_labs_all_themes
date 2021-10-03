using System;

namespace _011_Test_task2
{
    delegate Delegate3 Functional(Delegate1 delegate1, Delegate2 delegate2);
    delegate string Delegate1();
    delegate string Delegate2();
    delegate string Delegate3();
    class Program
    {
        public static Delegate3 MethodF(Delegate1 delegate1, Delegate2 delegate2)
        {
            return delegate { return delegate1.Invoke() + delegate2(); };
        }
        public static string Method1() { return "Hello "; }
        public static string Method2() { return "world!"; }
        static void Main(string[] args)
        {
            // моё решение
            Delegate1 delegate1 = new Delegate1(Method1);
            Delegate2 delegate2 = new Delegate2(Method2);
            Functional functional = new Functional(MethodF);
            Delegate3 delegate3 = functional(delegate1, delegate2);

            //Console.WriteLine(delegate3());

            //решение из видеокурса
            //Functional functional = new Functional(MethodF);
            //Delegate3 delegate3 = functional.Invoke(new Delegate1(Method1), new Delegate2(Method2));
            //Console.WriteLine(delegate3.Invoke());
            

            Console.ReadKey();
        }
    }
}

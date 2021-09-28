using System;

namespace Generics
{
    class MyClass<T, T2>
    {
        public T field;
        public T2 f2;
        public void Method()
        {
            Console.WriteLine(field.GetType());
            Console.WriteLine(f2.GetType());
        }
        
        public void Method<M>(M argument)
        {
            M variable = argument;
            Console.WriteLine("variable={0}", variable);
        }
    }

    class Gen1
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            //testSimpleGeneric();
            testDelegateGeneric();
        }

        static internal void testDelegateGeneric()
        {
            MyDelegate<int, int> myDelegate1 = new MyDelegate<int, int>(Add);
            int i = myDelegate1.Invoke(1);
            Console.WriteLine(i);

            MyDelegate<string, string> myDelegate2 = new MyDelegate<string, string>(Canc);
            string s = myDelegate2("sergio");
            Console.WriteLine(s);
        }

        private static int Add(int i)
        {
            return ++i;
        }
        private static string Canc(string s)
        {
            return "hello " + s + " !";
        }


        static internal void testSimpleGeneric()
        {
            MyClass<int, Gen1> inst1 = new MyClass<int, Gen1>();
            inst1.f2 = new Gen1();
            inst1.Method();

            // можно указывать тип передаваемого значения <M>, а можно не указывать, компилятор сам опеределит
            // все варианты ниже работают
            inst1.Method<string>("1fgsfd");
            inst1.Method(1);
            inst1.Method(new Gen1());

            //MyClass<long> inst2 = new MyClass<long>();
            //inst2.Method();

            //MyClass<string> inst3 = new MyClass<string>();
            //inst3.field = "qwe";
            //inst3.Method();
        }
    }

    
}

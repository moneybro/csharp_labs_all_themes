using System;

namespace GenericKovVarKontrVar
{
    public abstract class Shape { }
    public class Circle : Shape { }
    public class Kvadrat : Shape { }
    public class Treangle : Shape 
    {
        public string S3() 
        {
            return "площадь треугольника";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //new GenericInvariant().start();
            //new GenericKovariant().start();
            //new GenericKontrvariant().start();
            //new GenericDelegateKovar().start();
        }
    }
}

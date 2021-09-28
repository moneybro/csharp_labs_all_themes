using System;
using System.Collections.Generic;
using System.Text;

namespace GenericKovVarKontrVar
{
    public interface IContainer3<in T>
    {
        T Figure { set; }
    }
    
    public class Container3<T> : IContainer3<T>
    {
        private T figure;        
        public Container3(T figure)
        {
            this.figure = figure;
        }
        public T Figure
        {
            set { figure = value; }
        }

        public override string ToString()
        {
            return figure.GetType().ToString();
        }

    }
    class GenericKontrvariant
    {
        public void start()
        {
            Shape tr = new Treangle(); // предварительный upcast (приведение производного класса к базовому)
            IContainer3<Treangle> container = new Container3<Shape>(tr);
            Console.WriteLine(container.ToString());
        }
        
    }
}

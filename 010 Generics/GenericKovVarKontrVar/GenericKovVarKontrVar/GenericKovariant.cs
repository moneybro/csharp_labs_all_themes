using System;
using System.Collections.Generic;
using System.Text;

namespace GenericKovVarKontrVar
{
    public interface IContainer2<out T>
    {
        T Figure { get; }
    }

    public class Container2<T> : IContainer2<T>
    {
        private T figure;        
        public Container2(T figure)
        {
            this.figure = figure;
        }
        public T Figure
        {
            get { return figure; }
        }
        
    }
    class GenericKovariant
    {
        public void start()
        {
            Kvadrat kv = new Kvadrat();
            IContainer2<Shape> container = new Container2<Kvadrat>(kv);
            Console.WriteLine(container.Figure.ToString());
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GenericKovVarKontrVar
{
    public interface IContainer<T>
    {
        T Figure { get; set; }
    }

    public class Container<T> : IContainer<T>
    {
        public T Figure { get; set; }
        //T IContainer<T>.Figure { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Container(T figure)
        {
            this.Figure = figure;
        }
    }
    class GenericInvariant
    {
        public void start()
        {
            Circle circle = new Circle();
            IContainer<Circle> container = new Container<Circle>(circle);
            Console.WriteLine(container.Figure.ToString());
        }
        
    }
}

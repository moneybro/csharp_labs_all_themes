using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumerables
{
    class Progression: IEnumerable<int>
    {
        private readonly int _itemCount;
        public Progression(int itemCount)
        {
            _itemCount = itemCount;
        }

        public IEnumerator<int> GetEnumerator()
        {
            int current = 1;
            for (int i = 0; i < _itemCount - 1; i++)
            {
                if (i == 0) yield return 1;
                current += 3;
                yield return current;
            }
            //return new ProgressionIterator(_itemCount);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        static void Main(string[] args)
        {
            Progression progr = new Progression(100);
            foreach (int item in progr)
            {
                Console.WriteLine(item);
            }
        }

    }

    //public class ProgressionIterator : IEnumerator<int>
    //{
    //    private readonly int _itemCount;
    //    private int _position;
    //    private int _current;
    //    public ProgressionIterator(int itemCount)
    //    {
    //        _itemCount = itemCount;
    //        _current = 1;
    //        _position = 0;
    //    }

    //    public int Current => _current;

    //    object IEnumerator.Current => Current;

    //    public void Dispose()
    //    {
            
    //    }

    //    public bool MoveNext()
    //    {
    //        if(_position > 0) _current += 3;
    //        if(_position < _itemCount)
    //        {
    //            _position++;
    //            return true;
    //        }
    //        return false;
    //    }

    //    public void Reset()
    //    {
    //        _position = 0;
    //        _current = 1;
    //    }
    //}
}

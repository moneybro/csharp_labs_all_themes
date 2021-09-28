using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Collections
{
    class StoreCollection : ICollection<int>
    {
        private readonly string _filePath;

        public StoreCollection(string filePath)
        {
            _filePath = filePath;
        }
        static void Main(string[] args)
        {
            StoreCollection collection = new StoreCollection(@"d:\repos\labs\Collections\IntArray.txt");
            collection.Add(43521);
            foreach (var item in collection)
            {
                
                Console.WriteLine(item);
            }
        }
        private string[] GetNumbers()
        {
            string line = File.ReadAllText(_filePath);
            string[] numbers = line.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            return numbers;
        }

        //public int Count 
        //{
        //    get 
        //    {
        //        string[] numbers = GetNumbers();
        //        return numbers.Length;
        //    } 
        //}

        public int Count => GetNumbers().Length;

        public bool IsReadOnly => false;

        

        public void Add(int item)     // чтобы скрыть метод нужно явно реализовать метод
                                      // private void ICollection<int>.Add(int item)
        {
            string[] numbers = GetNumbers();
            if (numbers.Length == 0) File.WriteAllText(_filePath, item.ToString());
            else File.AppendAllText(_filePath, "," + item.ToString());
        }

        public void Clear()
        {
            File.WriteAllText(_filePath, "");
        }

        public bool Contains(int item)
        {
            string[] numbers = GetNumbers();
            foreach (string num in numbers)
            {
                if (Int32.Parse(num) == item)
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            string[] numbers = GetNumbers();
            foreach (string num in numbers)
            {
                array[arrayIndex] = Int32.Parse(num);
                arrayIndex++;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            string[] numbers = GetNumbers();
            foreach (string number in numbers)
            {
                yield return Int32.Parse(number);
            }
        }

        public bool Remove(int item)
        {
            string[] numbers = GetNumbers();
            string line = File.ReadAllText(_filePath);
            int symbolPosition = 0;

            foreach (string number in numbers)
            {
                if (Int32.Parse(number) == item)
                {
                    if (numbers.Length == 1)
                    {
                        line = "";
                    }
                    else if (symbolPosition == 0)
                    {
                        line = line.Substring(symbolPosition + number.Length + 1);
                    }
                    else
                    {
                        line = line.Remove(symbolPosition - 1, number.Length + 1);
                    }
                    File.WriteAllText(_filePath, line);
                    return true;
                }
                symbolPosition += number.Length + 1;
            }
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

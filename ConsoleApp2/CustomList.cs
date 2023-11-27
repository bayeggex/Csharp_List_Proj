using System;
using System.Reflection;

namespace ConsoleApp2
{
    public class CustomList<T>
    {
        public int Count => count;

        private T[] values;
        private int count;

        public CustomList()
        {
            values = new T[4];
            count = 0;
        }

        public void Add(T item)
        {
            if (count == values.Length)
            {
                Array.Resize(ref values, values.Length * 2);
            }
            values[count++] = item;
        }

        public void Remove(int index)
        {
            if (index >= 0 && index < count)
            {
                for (int i = index; i < count - 1; i++)
                {
                    values[i] = values[i + 1];
                }
                count--;
            }
        }

        public bool Contains(T item)
        {
            return Array.IndexOf(values, item) != -1;
        }

        public void Clear()
        {
            Array.Resize(ref values, 0);
            count = 0;
        }

        public void List()
        {
            foreach (var element in values)
            {
                Console.WriteLine(element);
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_01.Genarics
{
    public class Container<T> 
    {
        private T value;
        public void Add(T item)
        {
            value = item;
        }


        public T Get()
        {
            return value;
        }
        public void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public T FindMax<T>(T[] arr) where T : IComparable<T>
        {
            T max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(max) > 0)
                {
                    max = arr[i];

                }
            }
            return max;
        }
    }
}


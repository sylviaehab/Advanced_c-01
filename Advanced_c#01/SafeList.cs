using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_01
{
    public class SafeList<T>
    {
        private T[] list=new T[10];
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= list.Length)
                {
                    return default;
                }
                return list[index];
            }
            set
            {
                if (index < 0 || index >= list.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                list[index] = value;
            }
        }
    }
}

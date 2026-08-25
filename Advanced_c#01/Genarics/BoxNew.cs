using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_01.Genarics
{
    public class BoxNew<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }
    }
}

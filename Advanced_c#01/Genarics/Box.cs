using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_01.Genarics
{
    public class Box<T> where T:struct
    {
        public T Value { get; set; }
    }
}

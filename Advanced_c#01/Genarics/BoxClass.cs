using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_01.Genarics
{
    public class BoxClass<T> where T : class
    {
        public T Value { get; set; }
    
    }
}

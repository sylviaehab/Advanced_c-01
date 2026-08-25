using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_01.Genarics
{
    public class BoxInterface<T> where T : IComparable<T>
    {
        public BoxInterface() { }
    }
}

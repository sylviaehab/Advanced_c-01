using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_01.Genarics
{
    public class BoxMulti<T> where T : User, IComparable<T>, new()
    {
    }
}

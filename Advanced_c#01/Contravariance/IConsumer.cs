using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_01.Contravariance
{
    internal interface IConsumer<in T>
    {
        void Consume(T item);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_01.Covariance
{
    public interface IProducer<out T>
    {
        T Get();
    }
}

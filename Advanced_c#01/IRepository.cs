using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_01
{
    public interface IRepository<T>
    {
        void Add(T item);
        T Get(int id);
    }
}

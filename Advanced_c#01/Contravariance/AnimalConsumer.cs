using Advanced_c_01.Covariance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_01.Contravariance
{
    internal class AnimalConsumer : IConsumer<Animal>
    {
        void IConsumer<Animal>.Consume(Animal item)
        {
            Console.WriteLine("Animal consumed");
        }
    }
}

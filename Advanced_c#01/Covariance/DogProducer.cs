using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_01.Covariance
{
    public class DogProducer : IProducer<Dog>
    {
        Dog IProducer<Dog>.Get()
        {
           return new Dog();
        }
    }
}

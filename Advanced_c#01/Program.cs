
using Advanced_c_01.Contravariance;
using Advanced_c_01.Covariance;
using Advanced_c_01.Genarics;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Advanced_c_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //A generic class is a class that works with a type specified later using <T>.
            //We use generics because they:
            //Allow code reuse.
            // Provide type safety.
            //Work with different data types. 
            #endregion
            #region Question2
            Container<int> intContainer = new Container<int>();
            intContainer.Add(5);
            int value = intContainer.Get();
            Console.WriteLine(value);
            #endregion
            #region Question3
            //A generic class can have more than one type parameter.like int and string
            Pair<int, string> pair = new Pair<int, string>(5, "Hello");
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            #endregion

            #region Question4
            string x = "Hello";
            string y = "World";
            intContainer.swap(ref x, ref y);
            Console.WriteLine();
            Console.WriteLine($"After swapping: x = {x}, y = {y}");
            #endregion
            #region Question5
            int[] arr = { 10, 24, 7, 40, 15 };
            Console.WriteLine(intContainer.FindMax(arr));
            #endregion

            #region Question6
            //A generic interface is an interface that uses a type parameter. 
            #endregion

            #region Question7
            // It means T must be a value type.
            Box<int> box = new Box<int>();//valid
                                          // Box<string> box2 = new Box<string>();//invalid because string is a reference type 
            #endregion
            #region Question8
            //it must be a reference type
            //BoxClass<int> boxClass = new BoxClass<int>();//invalid
            BoxClass<string> boxClass2 = new BoxClass<string>();//valid 
            #endregion

            #region Question9
            //t means T must have a public parameterless constructor. 
            #endregion

            #region Question10
            //It means T must implement a specific interface. 
            #endregion

            #region Question11
            //It means T must inherit from a specific base class.
            //container inherits from user 
            #endregion
            #region Question12
            //You can combine constraints using where.
            //Inherit from user
            //Implement IComparable interface
            //Have a public parameterless constructor 
            #endregion

            #region Question13
            //default(T) returns the default value of type T.
            int z = default(int);//0
            string s = default(string);//null 
            #endregion
            #region Question14
            SafeList<int> safeList = new SafeList<int>();
            safeList[0] = 100;
            Console.WriteLine(safeList[20]);
            Console.WriteLine(safeList[0]);
            #endregion
            #region Question15
            //Covariance is the ability to use a more derived type than originally specified. It allows you to assign a more derived type to a less derived type. Covariance is supported in generic interfaces and delegates.using the out keyword.
            IProducer<Dog> dogs = new DogProducer();
            IProducer<Animal> animals = dogs;
            #endregion

            #region Question16
            //Contravariance allows you to use a less derived (base) type where a more derived type is expected.
            IConsumer<Animal> animals1 = new AnimalConsumer();

            IConsumer<Dog> dogs1 = animals1;
            //This works because an object that can accept any Animal can also accept a Dog. 
            #endregion
            #region Question17
            /*
                * | Covariance                             | Contravariance                         |
   | -------------------------------------- | -------------------------------------- |
   | Uses `out`                             | Uses `in`                              |
   | Derived → Base                         | Base → Derived                         |
   | Usually produces/returns values        | Usually consumes/accepts values        |
   | `IProducer<Dog>` → `IProducer<Animal>` | `IConsumer<Animal>` → `IConsumer<Dog>` |

                * 
                * 
                */
            #endregion

            #region Question18
            //Each different generic type has its own separate static members.
            /*
             * class Counter<T>
             {
               public static int Count;
             }

           Counter<int>.Count = 10;
           Counter<string>.Count = 20;
            Counter<int>    → Count = 10
             Counter<string> → Count = 20
            Changing one does not change the other.
             */
            #endregion
            //You can inherit from a generic class by specifying the type.
            Cache<int, string> cache = new Cache<int, string>();

            cache.Add(1, "Ahmed", TimeSpan.FromMinutes(5));
            cache.Add(2, "sylvia", TimeSpan.FromMinutes(5));


            Console.WriteLine(cache.Get(2));

            Console.WriteLine(cache.Contains(1));

            cache.Remove(1);

            Console.WriteLine(cache.Contains(1));
            
        }
    }
}

using System;

namespace SE2 // Slideshow Example 2 - Implicit Type Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // example 1: int (32-bit integer) to long (64-bit integer)
            int intNum = 1000;
            long longIntNum = intNum;
            Console.WriteLine("Implicit int to long conversion works!");

            // example 2: derived class to base class
            DerivedClassExample dClass = new DerivedClassExample();
            BaseClassExample bClass = dClass;
            Console.Write("Implicit derived class to base class conversion works!");
        }
    }
    class BaseClassExample
    {
        string name;
        string address;
    }
    class DerivedClassExample : BaseClassExample
    {
        string phoneNumber;
    }
}

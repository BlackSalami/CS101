using System;

namespace SE4 // Slideshow Example 4 - Explicit Type Conversions (Reference Types)
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClassExample dClassOne = new DerivedClassExample();
            BaseClassExample bClass = dClassOne; // implicit conversion

            // Explicit conversion is required to cast back
            // to derived type. Note: This will compile but will
            // throw an exception at run time if the right-side
            // object is not in fact a DerivedClassExample.
            DerivedClassExample dClassTwo = (DerivedClassExample)bClass;
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

using System;

namespace SE3 // Slideshow Example 3 - Explicit Type Conversions (Value Types)
{
    class Program
    {
        static void Main(string[] args)
        {
            double doubleFloatingPointNumber = 123.45;
            int integerNumber;

            integerNumber = (int)doubleFloatingPointNumber; // casting double to int;

            Console.WriteLine($"This is what happens when you explicitly convert a double (\"{doubleFloatingPointNumber}\") to an int:\nInt Value: {integerNumber}"); // prints value of int which is "123" (note that it ignores the decimals)
        }
    }
}

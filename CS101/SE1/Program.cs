using System;

namespace SE1 // Slideshow Example 1 - General
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer1 = 1; // first number
            int integer2 = 2; // second number

            int answer = AddTwoIntegers(integer1, integer2); // use function to get the sum

            Console.WriteLine($"{integer1} + {integer2} = {answer}"); // print output to console

            Console.ReadKey(); // key stroke required to end execution
        }
        private static int AddTwoIntegers(int a, int b) // this is a function that takes in two integer values and returns their sum
        {
            return a + b;
        }
    }
}
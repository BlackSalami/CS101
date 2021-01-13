using System;

namespace SE8 // Slideshow Example 8 - String Concatenation and Interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "this";

            // Concatenation Example 1
            Console.WriteLine("You" + " " + "can" + " do " + txt + ".");
            // Concatenation Example 2
            Console.WriteLine(String.Concat("Or even ", txt, "."));

            // Interpolation Example 1
            Console.WriteLine($"As seen in our course so far, you may also do {txt}.");
            Console.ReadKey();
        }
    }
}

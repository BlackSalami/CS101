using System;

namespace SE5 // Slideshow Example 5 - Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            Console.WriteLine($"x is {x} and y is {y}\n");

            Console.WriteLine($"(x + y) is equal to ({x} + {y}) which evaluates to {x + y}\n");

            Console.WriteLine($"(x += y) is equal to (x = x + y) which assigns x a value of {x += y}\n");
            // x is now equal to 5 + 10 as we assigned it a new value via the addition assignment compound operator

            Console.WriteLine($"x is now {x}...\n");

            Console.WriteLine($"the value of x-- is currently {x--} but is {x} afterwards\n");
            // x-- is the value of x before the decrement (15), after it is x - 1 (14)

            Console.WriteLine($"the value of --x is currently {--x} and is still {x} afterwards\n");
            // --x is the value of x after the decrement (13)

            int z = 12;
            Console.WriteLine($"Q: Is x ({x}) greater than {z}?\nA: {x > z}\n");

            x--; // postfix decrement x
            Console.WriteLine($"Q: What about after x--?\nA: {x > z}\n");

            Console.WriteLine($"Q: Is x now equal to {z}?\nA: {x == z}\n");

            Console.WriteLine($"Q: Is x still greater than y and equal to {z}?\nA: {x > y && x == z}");

            Console.Write($"\n\n== PRESS ANY KEY TO CLOSE ==");
            Console.ReadKey();
        }
    }
}

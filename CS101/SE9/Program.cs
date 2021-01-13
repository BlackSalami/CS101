using System;

namespace SE9 // Slideshow Example 9 - If...else statement(s) example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter \'A\', \'B\' or \'C\' to get a fruit: ");
            string input = Console.ReadLine();

            // converting lowercase "a" to uppercase "A" ...
            // this let's us avoid having to write conditions with logical OR operators "if (input == "A" || input == "a") ..."
            input = input.ToUpper();

            if (input == "A")
            {
                Console.WriteLine($"\nYou got an Apple!");
            }
            else if (input == "B")
            {
                Console.WriteLine($"\nYou got a Banana!");
            }
            else if (input == "C")
            {
                Console.WriteLine($"\nYou got a Cherry!");
            }
            else // invalid input
            {
                Console.WriteLine($"\nYou didn't enter A, B or C...");
                Console.WriteLine($"Naughty! Naughty! You get an Eggplant!");
            }
            Console.ReadKey();
        }
    }
}

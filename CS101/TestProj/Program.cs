using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Primary User Input
            Console.Write("Enter a number or a random message: ");
            string input = Console.ReadLine();
            #endregion

            #region Parsing, Condition, Operations and Output
            double number;
            if (Double.TryParse(input, out number))
            {
                #region If a number
                Console.Write("Enter another number to perform a multiplication operation: ");
                string secondaryInput = Console.ReadLine();

                double numberTwo = Convert.ToDouble(secondaryInput);

                Console.WriteLine($"{number} x {numberTwo} = {number * numberTwo}");
                #endregion
            }
            else
            {
                #region If NOT a number
                Console.Write("Enter a part of your message you'd like to replace (caps sensitive): ");
                string secondaryInput = Console.ReadLine();

                Console.Write($"Enter what you'd like to replace \"{secondaryInput}\" with: ");
                string tertiaryInput = Console.ReadLine();

                Console.WriteLine($"New Message: \"{input.Replace(secondaryInput, tertiaryInput)}\"");
                #endregion
            }
            #endregion
            Console.Write($"\n== PRESS ANY KEY TO EXIT ==");
            Console.ReadKey();
        }
    }
}

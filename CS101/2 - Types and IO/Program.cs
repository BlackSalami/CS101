using System;

namespace _2___Types_and_IO
{
    class Program
    {
        static void Main(string[] args)
        { 
            // our prompt; the Write (instead of WriteLine) method allows us to not break to a new line after we print to the console
            Console.Write("Enter a number with decimals (e.g. 12.43): ");

            // our input string variable will be assigned whatever the user enters into the console window via Console.ReadLine();
            string input = Console.ReadLine();

            // convert string input to double dfpNumber, will throw exception if input is invalid
            double dfpNumber = Convert.ToDouble(input);

            // use a cast to explicity convert the double into an int
            int intNumber = (int)dfpNumber;

            // print our output and read key so app does not exit without key input
            Console.WriteLine($"Your (string) input: {input}\nDouble: {dfpNumber}\nInt: {intNumber}");
            Console.ReadKey();
        }
    }
}

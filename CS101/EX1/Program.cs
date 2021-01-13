using System;

namespace EX1 // Exercise One - Input, Output, Conditions and Operations
{
    /// <summary>
    /// 
    /// Code a console app that takes in some user input and either:
    /// 
    /// A) IF THE INPUT IS A NUMBER:
    ///     1 - Ask the user to input another number.
    ///     2 - Perform a mathematical operation using both numbers.
    ///     3 - Return the sum/product/whatever as output to console.
    /// 
    /// B) IF THE INPUT IS NOT A NUMBER:
    ///     1 - Ask the user to input two strings:
    ///         String #1: one to search for and replace with...
    ///         String #2: another string (https://docs.microsoft.com/en-us/dotnet/api/system.string.replace?view=net-5.0#System_String_Replace_System_String_System_String_)
    ///     2 - Return the newly created string object as output to console.
    /// 
    /// HINT: Use the Double.TryParse method (https://docs.microsoft.com/en-us/dotnet/api/system.double.tryparse?view=net-5.0) to parse a numerical value!
    /// You will need to define a numerical variable to pass to the TryParse method.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}

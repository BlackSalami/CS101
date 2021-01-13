using System;

namespace SE7 // Slideshow Example 7 - Common String Methods and Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // The String object class (like most in C#) has a LOT of methods, fields and properties. These are only a few.

            string txt = "Hello World!";
            int txtLen = txt.Length; // returns length of a string - "Length" is a property of the String object
            Console.WriteLine($"the string \"{txt}\" has a length of {txtLen}\n");

            string txtUpper = txt.ToUpper(); // returns copy of string in uppercase - "ToUpper()" is a method of the String object
            string txtLower = txt.ToLower(); // returns copy of string in lowercase
            Console.WriteLine($"Uppercase=\"{txtUpper}\", Lowercase=\"{txtLower}\"\n");

            string searchFor = "Hello";
            Console.WriteLine($"Q: Does \"{txt}\" contain the text \"{searchFor}\"?\nA: {txt.Contains(searchFor)}\n"); // returns true if specified string can be found within another string

            string txtToFormat = "Hello {0}! It sure is a {1} day today."; // Curly braces with indexes ("{0}", "{1}", "{2}", etc...) can be used by string.Format() to format items in a string with the string representation of 1 or more objects.
            string formattedTxt = string.Format(txtToFormat, "Bob", "sunny"); // Using string.Format to replace {0} with Bob and {1} with sunny.
            Console.WriteLine(formattedTxt + "\n");

            string jim = "Jim";
            formattedTxt = formattedTxt.Replace("Bob", jim); // returns a new string object where every occurance of "Bob" is replaced with "Jim"
            Console.WriteLine(formattedTxt + "\n");

            // substring(x, y) returns a section of a string starting at index x and ending at index y.
            // indexof(x) returns the zero-based index of the first occurance of a string/character
            formattedTxt = formattedTxt.Substring(formattedTxt.IndexOf(jim), jim.Length + 1);
            Console.WriteLine(formattedTxt);
            Console.ReadKey();
        }
    }
}

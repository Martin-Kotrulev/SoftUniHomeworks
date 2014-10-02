using System;
//Problem 7.	Quotes in Strings
//Declare two string variables and assign them with following value:
//The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings. Print the variables to ensure that their value was correctly defined.

class QuotesInString
{
    static void Main()
    {
        string quoted = "The \"use\" of quotations causes difficulties.";
        string unqoted = "The use of quotations causes difficulties.";
        Console.WriteLine("Quoted: {0}\nUnqouted: {1}", quoted, unqoted);
    }
}
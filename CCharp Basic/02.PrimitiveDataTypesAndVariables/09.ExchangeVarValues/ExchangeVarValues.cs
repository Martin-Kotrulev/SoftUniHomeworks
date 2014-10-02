using System;
//Problem 9.	Exchange Variable Values
//Declare two integer variables a and b and assign them with 5 and 10
//and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

class ExchangeVarValues
{
    // reference method to change the values directly
    static void ExchangeValues(ref int a, ref int b)
    {
        int swap = a;
        a = b;
        b = swap;
    }
    static void Main()
    {
        int a = 5;
        int b = 10;
        ExchangeValues(ref a, ref b);
        Console.WriteLine("a = {0}, b = {1}", a, b);
    }
}
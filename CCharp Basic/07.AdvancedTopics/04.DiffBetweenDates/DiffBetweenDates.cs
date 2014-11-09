using System;
//Problem 4.	Difference between Dates
//Write a program that enters two dates in 
//format dd.MM.yyyy and returns the number 
//of days between them.

class DiffBetweenDates
{
    static void Main()
    {
        DateTime first = DateTime.ParseExact(
            Console.ReadLine(), "dd.MM.yyyy", 
            System.Globalization.CultureInfo.InvariantCulture);
        DateTime second = DateTime.ParseExact(
            Console.ReadLine(), "dd.MM.yyyy", 
            System.Globalization.CultureInfo.InvariantCulture);

        int diff = (first - second).Days;

        Console.WriteLine(diff);
    }
}
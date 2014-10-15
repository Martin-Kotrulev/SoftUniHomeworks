using System;
//Problem 7.	Sum of 5 Numbers
//Write a program that enters 5 numbers 
//(given in a single line, separated by a space), 
//calculates and prints their sum. 

class SumOf5Nmbs
{
    static void Main()
    {
        int sum = 0;
        char digit;

        do
        {
            digit = (char)Console.Read();
            int number = (digit - '0');
            digit = (char)Console.Read();

            while (digit != 32 && digit != 13)
            {
                number = number * 10 + (digit - '0');
                digit = (char)Console.Read();
            }
            sum += number;
        } while (digit != 13);

        Console.WriteLine(sum);
    }
}
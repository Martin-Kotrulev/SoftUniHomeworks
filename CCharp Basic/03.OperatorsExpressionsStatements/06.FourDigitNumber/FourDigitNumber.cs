using System;
using System.Collections.Generic;
using System.Text;
//Problem 6.	Four-Digit Number
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//•	Prints on the console the number in reversed order: dcba (in our example 1102).
//•	Puts the last digit in the first position: dabc (in our example 1201).
//•	Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0. 

class FourDigitNumber
{
    static int PutLastToFirst(int num)
    {
        int last = num % 10;
        num /= 10;
        last = last * 1000 + num;
        return last;
    }
    //static string ExchangeSecondAndThird(string num)
    //{
    //    char[] number = new char[num.Length];
    //    for (int i = 0; i < num.Length; i++)
    //    {
    //        if (i != 0 && i != num.Length - 1)
    //        {
    //            char swap = num[i];
                
    //        }
    //        else number[i] = num[i];
    //    }
    //}
    static int ReverseNumber(int n)
    {
        int reversed = 0;
        int currentDgt = 0;

        while (n != 0)
        {
            currentDgt = n % 10;
            reversed += currentDgt;
            n /= 10;
            if (n != 0) reversed *= 10;
        }
        return reversed;
    }
    static void Main()
    {

        // reads any number digit by digit
        char digit = (char)Console.Read();
        int n = digit - '0'; // convert char to real value
        int sum = n;

        do
        {
            digit = (char)Console.Read();
            if (digit != 13)
            {
                sum += digit - '0';
                n = n * 10 + (digit - '0');
            }

        } while (digit != 13); // 13 is ENTER
        int reversed = ReverseNumber(n);
        Console.WriteLine(sum);
        Console.WriteLine(reversed);
        Console.WriteLine(PutLastToFirst(n));
    }
}
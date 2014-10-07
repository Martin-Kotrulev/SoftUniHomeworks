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
    static int PutLastToFirst(int num, ref int lastDigit, out int current)
    {
        num /= 10;
        current = 0;
        if (num != 0)
        {
            // Recursive call to calculate the digits in the number
            PutLastToFirst(num, ref lastDigit, out current);
            //------------Stack Returns:
            lastDigit *= 10; // on every call move last digit 1 pos left
            current = lastDigit; // saving current result to be returned after
        }
        return num;
    }

    static void ExchangeSecondAndThird(string num)
    {
        char[] number = new char[num.Length];
        for (int i = 0; i < number.Length; i++)
        {
            if (i != 1 && i != num.Length - num.Length + 2)
            {
                number[i] = num[i];
            }
            else if (i == 1)
            {
                number[i] = num[i + 1];
                number[i + 1] = num[i];
            }
            Console.Write(number[i]);
        }
    }

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
        Console.WriteLine(sum);

        // reversed
        int reversed = ReverseNumber(n);
        Console.WriteLine(reversed);

        // exchange second and third operation
        ExchangeSecondAndThird(n.ToString());
        Console.WriteLine();

        // last to first operation
        int lastDigit = n % 10;
        int converted;
        int firstDigits = PutLastToFirst(n, ref lastDigit, out converted);
        Console.WriteLine(converted + firstDigits);
    }
}
using System;
//Problem 4.	Multiplication Sign
//Write a program that shows the sign (+, - or 0) of the product 
//of three real numbers, without calculating it. Use a sequence of if operators. 

class MultiplicationSign
{
    static void Main()
    {
        char sign = '+';
        int negativeCtr = 0;

        for (int i = 0; i++ < 3; )
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 0) sign = '0'; // is some is zero answer==0
            if (num < 0) negativeCtr++;
        }
        // if the number of negatives is odd answer=='-'
        if ((negativeCtr & 1) == 1 && sign != '0') sign = '-';

        Console.WriteLine(sign);
    }
}
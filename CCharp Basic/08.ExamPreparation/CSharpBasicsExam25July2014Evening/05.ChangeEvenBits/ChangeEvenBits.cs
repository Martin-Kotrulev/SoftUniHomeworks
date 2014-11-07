using System;
//Problem 5 – Change Even Bits
//You are given a number N and you have to read 
//from the console exactly N + 1 integers and 
//additionally an integer L – the number to be 
//processed. Your task is to count the bits in 
//each of the N input integers (let this be the
//number len), then change bit to "1" len even 
//positions (0, 2, 4, …) of the input number L.
//Print on the console the obtained number and the
//total number of bits that have actually been changed.
//To be counted as changed they should have been “0” at
//first and then changed to “1”. The comments in the 
//example below will help you understand better what you
//should do. Note that "0" consists of 1 bit (len=1).

//Input
//The input data should be read from the console.
//•	The first line holds an integer number N – 
//the count of numbers to be read.
//•	The next N lines hold the N input integers.
//•	The last line holds an integer number L – 
//the number to be processed.
//The input data will always be valid and in the 
//format described. There is no need to check it.

//Output
//The output should be printed on the console. 
//It should consist of exactly 2 lines:
//•	On the first line print the number L 
//after setting its even bits.
//•	On the second line print the number 
//of bits that have actually changed.

// SOLUTION CHECKED - 100%

class ChangeEvenBits
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int[] n = new int[input];
        for (int i = 0; i < n.Length; i++) 
            n[i] = int.Parse(Console.ReadLine());
        ulong L = ulong.Parse(Console.ReadLine());

        int bitsChanged = 0;
        for (int i = 0; i < n.Length; i++)
        {
            int len = Convert.ToString(n[i], 2).Length;
            int evenPos = 0;
            while (len > 0)
            {
                if (((L >> evenPos) & 1) == 0) bitsChanged++;
                L |= (ulong)1 << evenPos; 
                evenPos += 2;
                len--;
            }
        }

        Console.WriteLine(L);
        Console.WriteLine(bitsChanged);
    }
}
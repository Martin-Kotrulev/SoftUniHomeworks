using System;
//Problem 1.	Declare Variables
//Declare five variables choosing for each of them the most 
//appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong 
//to represent the following values: 52130, -115, 4825932, 97, -10000. 
//Choose a large enough type for each number to ensure it will fit in it. 
//Try to compile the code. Submit the source code of your 
//Visual Studio project as part of your homework submission.

class DeclareVariables
{
    static void Main()
    {
        ushort ushortNum = 52130;
        sbyte sbyteNum = -115;
        long longNum = 4825932;
        byte byteNum = 97;
        short shortNum = -10000;
        Console.WriteLine(
            "ushort: {0}\nsbyte: {1}\nlong: {2}\nbyte: {3}\nshort: {4}",
            ushortNum, sbyteNum, longNum, byteNum, shortNum);
    }
}
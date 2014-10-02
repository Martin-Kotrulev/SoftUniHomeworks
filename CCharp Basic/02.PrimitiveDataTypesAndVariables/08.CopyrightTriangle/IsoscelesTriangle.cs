using System;
using System.Text;
using System.Threading;
using System.Globalization;
//Problem 8.	Isosceles Triangle
//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©   
//  © ©  
// ©   © 
//© © © ©
//Note that the © symbol may be displayed incorrectly at 
//the console so you may need to change the console character 
//encoding to UTF-8 and assign a Unicode-friendly font in the 
//console. Note also, that under old versions of Windows the 
//© symbol may still be displayed incorrectly, regardless of 
//how much effort you put to fix it.

class CopyrightTriangle
{
    static void Main()
    {
        //reset regional settings and using UTF-8 encoding to properly print the copyright sign;
        Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;
        Console.OutputEncoding = Encoding.UTF8;

        int size = 7;              //size of the triangle(works for any size)
        char cR = '\u00A9';

        // printing the top of the triangle
        string top = new string(' ', size / 2);
        Console.WriteLine(top + cR + top);

        int innerCtr = 1;           // counter for inner spaces
        for (int row = 1; row < (size / 2); row++)
        {
                string outSpaces = new String(' ', (size / 2) - row);
                string innerSpaces = new String(' ', innerCtr);
                Console.WriteLine(outSpaces + cR + innerSpaces + cR + outSpaces);
                innerCtr += 2;
        }
        // printing the bottom line
        for (int i = 0; i < size / 2 + 1; i++)
        {
            Console.Write(cR);
            Console.Write(' ');
        }
    }
}
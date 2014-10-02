using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 12.	Null Values Arithmetic
//Create a program that assigns null values to an integer 
//and to a double variable. Try to print these variables at the console.
//Try to add some number or the null literal to these 
//variables and print the result.

class NullValuesArithmetic
{
    static void Main()
    {
        int? num = null;
        double? floating = null;
        Console.WriteLine("int: {0} double: {1}", num, floating);

        num += 2;
        floating += floating;
        Console.WriteLine("int: {0} double: {1}", num, floating);
    }
}
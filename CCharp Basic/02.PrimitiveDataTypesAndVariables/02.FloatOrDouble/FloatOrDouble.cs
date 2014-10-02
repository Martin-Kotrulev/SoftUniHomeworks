using System;
//Problem 2.	Float or Double?
//Which of the following values can be assigned to a variable of type float 
//and which to a variable of type double: 
//34.567839023, 12.345, 8923.1234857, 3456.091? 
//Write a program to assign the numbers in 
//variables and print them to ensure no precision is lost.


class FloatOrDouble
{
    static void Main()
    {
        double first = 34.567839023;
        float second = 12.345F;
        double third = 8923.1234857;
        float fourth = 3456.091F;
        Console.WriteLine("Double: {0}; {1}", first, third);
        Console.WriteLine("Float: {0}; {1}", second, fourth);
    }
}
using System;
//Problem 9.	Play with Int, Double and String
//Write a program that, depending on the user’s choice, 
//inputs an int, double or string variable. If the variable
//is int or double, the program increases it by one. 
//If the variable is a string, the program appends "*" 
//at the end. Print the result at the console. Use switch statement. 


class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose type:\n1 --> int\n2 --> double\n3 -- > string");

        switch (Console.ReadLine())
        {
            case "1":
                Console.Write("Please enter an int: ");
                int i = int.Parse(Console.ReadLine()) + 1;
                Console.WriteLine(i);
                break;
            case "2":
                Console.Write("Please enter a double: ");
                double d = double.Parse(Console.ReadLine()) + 1;
                Console.WriteLine(d);
                break;
            case "3":
                Console.Write("Please enter a string: ");
                string s = Console.ReadLine() + '*';
                Console.WriteLine(s);
                break;
            default:
                break;
        }
    }
}
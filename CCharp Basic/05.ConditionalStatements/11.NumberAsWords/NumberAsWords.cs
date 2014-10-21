using System;
//Problem 11.	* Number as Words
//Write a program that converts a number in the range 
//[0…999] to words, corresponding to the English pronunciation. 

class NumberAsWords
{
    static string[] numbersTo19 = {"zero", "one", "two", "three", "four", 
                             "five", "six", "seven", "eight","nine",
                             "ten", "eleven", "twelve", "thirteen",
                             "fourteen", "fifteen", "sixteen", "seventeen",
                             "eighteen", "nineteen"};
    static string[] tens = {"", "", "twenty", "thirty", "fourty", "fifty", "sixty", 
                           "seventy", "eighty", "ninety"};    
    static void Main()
    {
        string input = Console.ReadLine();
        int num = int.Parse(input);

        if (num > 19)
        {
            if (num > 99)
            {
                Console.Write(" {0}", numbersTo19[num / 100]);
                Console.Write(" hundred");
                if (num % 100 != 0) Console.Write(" and");
            }

            num %= 100;
            Console.Write(" {0}", tens[num / 10]);
            if ((num % 10) > 0) Console.Write(" {0}", numbersTo19[num % 10]);

            Console.WriteLine();
        }
        else Console.WriteLine(" {0}", numbersTo19[num]);
    }
}
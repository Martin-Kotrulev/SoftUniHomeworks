using System;
using System.Collections.Generic;
//Problem 10.	* Beer Time
//A beer time is after 1:00 PM and before 3:00 AM. 
//Write a program that enters a time in format “hh:mm tt” 
//(an hour in range [01...12], a minute in range [00…59] 
//and AM / PM designator) and prints “beer time” or “non-beer time” 
//according to the definition above or “invalid time” if the 
//time cannot be parsed. Note that you may need to learn how to parse dates and times. 

class BeerTime
{
    static string[] SplitTime(string s, char[] separatorChars)
    {
        List<string> list = new List<string>();
        string swap = "";
        bool isSeparator = false;

        for (int i = 0; i < s.Length; i++)
        {
            foreach (var item in separatorChars)
            {
                if (s[i] == item || s[i] == 13)
                {
                    isSeparator = true;
                    list.Add(swap);
                    swap = "";
                }
            }
            if (isSeparator)
            {
                isSeparator = false;
                continue;
            }
            swap += s[i];
        }
        list.Add(swap); // adding last element

        string[] returned = new string[list.Count];

        for (int i = 0; i < list.Count; i++)
        {
            returned[i] = list[i];
        }

        return returned;
    }

    static void Main()
    {
        char[] separators = { ':', ' ' };
        string[] input = SplitTime(Console.ReadLine(), separators);

        if (int.Parse(input[0]) >= 01 && input[2] == "PM" ||
            int.Parse(input[0]) < 03 && input[2] == "AM")
        {
            Console.WriteLine("Beer Time!");
        }
        else Console.WriteLine("Non-beer time!");
    }
}
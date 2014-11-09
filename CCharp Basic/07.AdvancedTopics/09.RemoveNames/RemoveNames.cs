using System;
using System.Text;
//Problem 9.	Remove Names
//Write a program that takes as input two lists of 
//names and removes from the first list all names 
//given in the second list. The input and output 
//lists are given as words, separated by a space, 
//each list at a separate line. 

class RemoveNames
{
    static void Main()
    {
        StringBuilder toBeProcessed = new StringBuilder(Console.ReadLine());
        string[] namesMatches = Console.ReadLine().Trim().Split(' ');
        
        for (int i = 0; i < namesMatches.Length; i++)
            toBeProcessed.Replace(namesMatches[i], string.Empty);

        string[] final = toBeProcessed.ToString().Split(' ');
        for (int i = 0; i < final.Length; i++)
            Console.Write(i > 0 ? " {0}" : "{0}", final[i]);
    }
}
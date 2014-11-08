using System;
using System.Text;
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
            Console.WriteLine(i > 0 ? " {0}" : "{0}", final[i]);
    }
}
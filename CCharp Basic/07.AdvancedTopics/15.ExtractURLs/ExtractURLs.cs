using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
//Problem 15.	Extract URLs from Text
//Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
//•	http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
//•	www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com
//Examples:

class ExtractURLs
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> links = new List<string>();

        Regex r = new Regex(@"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$]*");
        Match m = r.Match(input);
        while (m.Success)
        {
            links.Add(m.ToString());
            m = m.NextMatch();
        }

        foreach (var item in links) Console.WriteLine(item);
    }
}
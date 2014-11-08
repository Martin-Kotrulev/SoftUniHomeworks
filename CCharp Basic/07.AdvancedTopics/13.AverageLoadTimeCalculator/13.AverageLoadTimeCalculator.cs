using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
//Problem 13.	Average Load Time Calculator
//We have a report that holds dates, web site URLs 
//and load times (in seconds) in the same format 
//like in the examples below. Your tasks is to calculate 
//the average load time for each URL. Print the URLs 
//in the same order as they first appear in the input 
//report. Print the output in the format given below. 
//Use double floating-point precision. 

class AverageLoadTimeCalculator
{
    static void Main(string[] args)
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.InvariantCulture;
        Dictionary<string, decimal> sitesValues = 
            new Dictionary<string, decimal>();
        Dictionary<string, int> sitesCount =
            new Dictionary<string, int>();

        StreamReader inputReader = new StreamReader("../../input.txt");
        string file = inputReader.ReadToEnd();
        string[] lines  = file.Split(new[] { Environment.NewLine }, 
            StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < lines.Length; i++)
        {
            string[] currentLine = lines[i].Split(' ');
            if (!sitesValues.ContainsKey(currentLine[2]))
            {
                sitesValues.Add(currentLine[2], decimal.Parse(currentLine[3]));
                sitesCount.Add(currentLine[2], 1);
            }
            else
            {
                sitesValues[currentLine[2]] += decimal.Parse(currentLine[3]);
                sitesCount[currentLine[2]]++;
            }

        }
        // calculating average
        foreach (var site in sitesCount)
            sitesValues[site.Key] = sitesValues[site.Key] / site.Value; 

        foreach (var site in sitesValues)
            Console.WriteLine("{0} -> {1}", site.Key, site.Value);
    }
}
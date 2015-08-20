using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

/*
 * 01. Find Words in File
 * Write a program that finds a set of words (e.g. 1000 words) in a 
 * large text (e.g. 100 MB text file). Print how many times each word 
 * occurs in the text. Ensure your program works fast enough.
 * Hint: use Dictionary<string, int>.
 */
namespace FindWordsInFile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = File.ReadAllText("../../1000wordsFile.txt");
            var wordsCounter = new Dictionary<string, int>();

            var words = text.Split(new char[] { ',', ' ', '.' },
                StringSplitOptions.RemoveEmptyEntries);

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            foreach (var word in words)
            {
                if (wordsCounter.ContainsKey(word))
                {
                    wordsCounter[word]++;
                }
                else
                {
                    wordsCounter.Add(word, 1);
                }
            }
            var elapsed = stopWatch.Elapsed;

            foreach (var entry in wordsCounter)
            {
                Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
            }

            Console.WriteLine("Elapsed time for the words counting: " 
                + elapsed.TotalSeconds);
        }
    }
}
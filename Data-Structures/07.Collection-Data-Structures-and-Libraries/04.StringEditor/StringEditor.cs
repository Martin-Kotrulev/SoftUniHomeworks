using System;
using Wintellect.PowerCollections;
using System.IO;
using System.Diagnostics;

/*
 * String Editor
 * You have to implement a string editor that starts from empty string and 
 * executes sequence of commands:
 * INSERT some_string position – inserts given string at given position. Print "ERROR" 
 * in case of invalid position.
 * APPEND some_string – appends given string at the end of the text.
 * DELETE start_index count – deletes the specified substring. Print "ERROR" in case of 
 * invalid substring.
 * REPLACE start_index count some_string – replaces the specified substring with the 
 * specified string. Print "ERROR" in case of invalid substring.
 * PRINT – prints the string in the editor.
 * Ensure your programs runs efficiently for tens of thousands of commands.
 * Hint: use rope of chars.
 * 
 * TODO: CLEAR SOME BUGS IN THE COMMANDS.
 */
namespace StringEditor
{
    class MainClass
    {
        private static BigList<char> text = new BigList<char>();
        private static string[] tokens;

        private static void Insert()
        {
            string value = tokens[1];
            int position = int.Parse(tokens[2]);
            if (position < 0 || position > text.Count - 1)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                for (int i = 0; i < value.Length; i++)
                {
                    text.Insert(position, value[i]);
                    position++;
                }
            }
        }

        private static void Append(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                text.Add(value[i]);
            }
        }

        private static void Delete(int startIndex, int count)
        {
            if (startIndex < 0 || startIndex > text.Count - 1 
                || startIndex + count > text.Count)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                for (int i = startIndex; i < count; i++)
                {
                    text.RemoveAt(i);
                }
            }
        }

        private static void Replace()
        {
            int startIndex = int.Parse(tokens[1]);
            int count = int.Parse(tokens[2]);
            string value = tokens[3];
            if (startIndex < 0 || count < 1 || startIndex + value.Length > text.Count - 1
                || startIndex > text.Count - 1 || startIndex + count > text.Count - 1)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                Delete(startIndex, count);
                for (int i = 0; i < value.Length; i++)
                {
                    text.Insert(startIndex, value[i]);
                    startIndex++;
                }
            }
        }

        private static void Print()
        {
            Console.WriteLine(string.Join("", text.ToArray()));
        }

        private static void ExecuteCommand(string command)
        {
            switch (command)
            {
                case "INSERT":
                    Insert();
                    break;
                case "APPEND":
                    Append(tokens[1]);
                    break;
                case "DELETE":
                    Delete(int.Parse(tokens[1]), int.Parse(tokens[2]));
                    break;
                case "REPLACE":
                    Replace();
                    break;
                case "PRINT":
                    Print();
                    break;
                default:
                    break;
            }
                    
        }

        private static void ManageInput(string input)
        {
            tokens = input.Split(' ');
            string command = tokens[0];
            ExecuteCommand(command);
        }

        private static void TestMethod()
        {
            string value = File.ReadAllText("../../10000words.txt");
            var words = value.Split(new char[] { ',', ' ', '.' },
                StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var word in words)
            {
                Append(word);
            }
            Print();
        }

        public static void Main(string[] args)
        {
            /*
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "EXIT")
                {
                    Console.WriteLine("Bye!");
                    break;
                }
                ManageInput(input);
                Console.WriteLine(new string('*', 50) + '\n');
            }
            */

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            TestMethod();
            Console.WriteLine("10000 appends for " + stopwatch.Elapsed.TotalSeconds);
        }
    }
}
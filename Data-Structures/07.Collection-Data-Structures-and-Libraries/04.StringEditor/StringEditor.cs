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

        private static void Insert(string value, int position)
        {
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
                || (startIndex + count) - 1 > text.Count - 1)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    text.RemoveAt(startIndex);
                }
            }
        }

        private static void Replace(int startIndex, int count, string replaceValue)
        {
            if (startIndex < 0 || count < 1 || startIndex > text.Count - 1)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                Delete(startIndex, count);
                for (int i = 0; i < replaceValue.Length; i++)
                {
                    text.Insert(startIndex, replaceValue[i]);
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
            try 
            {
                switch (command)
                {
                    case "INSERT":
                        Insert(tokens[1], int.Parse(tokens[2]));
                        break;
                    case "APPEND":
                        Append(tokens[1]);
                        break;
                    case "DELETE":
                        Delete(int.Parse(tokens[1]), int.Parse(tokens[2]));
                        break;
                    case "REPLACE":
                        Replace(int.Parse(tokens[1]), int.Parse(tokens[2]), tokens[3]);
                        break;
                    case "PRINT":
                        Print();
                        break;
                    case "HELP":
                        Help();
                        break;
                    case "SPEEDTEST":
                        TestAppendPerformance();
                        break;
                    default:
                        Console.WriteLine("INVALID COMMAND.");
                        break;
                }
            } catch(Exception)
            {
                Console.WriteLine("ERROR");
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
        }

        private static void TestAppendPerformance()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            TestMethod();
            Console.WriteLine("10000 appends for " + stopwatch.Elapsed.TotalSeconds);
        }

        private static void Help()
        {
            Console.WriteLine("STRING BUILDING CONSOLE APP");
            Console.WriteLine(new String('*', 30));
            Console.WriteLine("COMMANDS:");
            Console.WriteLine("INSERT some_string position – inserts given string at given position."); 
            Console.WriteLine("APPEND some_string – appends given string at the end of the text.");
            Console.WriteLine("DELETE start_index count – deletes the specified substring.");
            Console.WriteLine("REPLACE start_index count some_string – \n\treplaces the specified substring with specified string.");
            Console.WriteLine("PRINT – prints the string in the editor.");
            Console.WriteLine("HELP - print commands.");
            Console.WriteLine("SPEEDTEST - Perform speed test for append method.");
            Console.WriteLine("EXIT - exits the app.");
            Console.WriteLine(new String('*', 30) + "\n");
        }

        public static void Main(string[] args)
        {
            Help();
            while (true)
            {
                Console.Write("Enter command > ");
                string input = Console.ReadLine();
                if (input == "EXIT")
                {
                    Console.WriteLine("Bye!");
                    break;
                }
                ManageInput(input);
                Console.WriteLine(new string('*', 50) + '\n');
            }
        }
    }
}
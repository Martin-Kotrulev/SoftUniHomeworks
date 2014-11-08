using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WeirdCombinations
{
    class WeirdCombinations
    {
        static void Main(string[] args)
        {
            char[] cin = Console.ReadLine().ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] loops = new int[cin.Length];
            List<string> combinations = new List<string>();

            int pos;
            while (true)
            {
                combinations.Add(MakeCombination(loops, cin));
                pos = cin.Length - 1;
                loops[pos]++;
                while (loops[pos] > cin.Length - 1)
                {
                    loops[pos] = 0;
                    pos--;
                    if (pos < 0)
                    {
                        if (n > combinations.Count - 1) Console.WriteLine("No");
                        else Console.WriteLine(combinations[n]);
                        return;
                    }
                    loops[pos]++;
                }
            }
        }

        private static string MakeCombination(int[] loops, char[] cin)
        {
            string combination = "";
            for (int i = 0; i < cin.Length; i++)
            {
                combination += cin[loops[i]];
            }

            return combination;
        }
    }
}

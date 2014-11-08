using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOrEvenCounter
{
    class OddOrEvenCounter
    {
        static string GetStringRepresentation(int i)
        {
            switch (i)
            {
                case 0: return "First";
                case 1: return "Second";
                case 2: return "Third";
                case 3: return "Fourth";
                case 4: return "Fifth";
                case 5: return "Sixth";
                case 6: return "Seventh";
                case 7: return "Eighth";
                case 8: return "Ninth";
                case 9: return "Tenth";
            }

            return "0";
        }

        static void Main(string[] args)
        {
            int sets = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            string numbersToCount = Console.ReadLine();
            bool match = false;
            int[] setCounter = new int[sets];

            for (int i = 0; i < sets; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    int current = int.Parse(Console.ReadLine());
                    if (numbersToCount == "odd" && current % 2 > 0) setCounter[i]++;
                    else if (numbersToCount == "even" && current % 2 == 0) setCounter[i]++;
                }
            }

            int bestCount = 0;
            int bestSet = 0;
            for (int i = 0; i < setCounter.Length; i++)
            {
                if (setCounter[i] > 0) match = true;
                if (setCounter[i] > bestCount)
                {
                    bestCount = setCounter[i];
                    bestSet = i;
                }
            }

            if (!match)
            {
                Console.WriteLine("No");
            }
            else Console.WriteLine(
                "{0} set has the most {1} numbers: {2}",
                GetStringRepresentation(bestSet), numbersToCount, bestCount);
        }
    }
}

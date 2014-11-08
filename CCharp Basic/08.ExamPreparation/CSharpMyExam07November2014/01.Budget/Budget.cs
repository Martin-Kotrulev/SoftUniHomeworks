using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Budget
{
    class Budget
    {
        static void Main(string[] args)
        {
            int money = int.Parse(Console.ReadLine());
            int goesOut = int.Parse(Console.ReadLine());
            int homeWeekends = int.Parse(Console.ReadLine());
            int weekDays = 22;
            int partyWeekends = 4 - homeWeekends;
            decimal threePercent = (money * 97 / (decimal)100);
            int percentLeft = (int)Math.Floor(threePercent);
            percentLeft = money - percentLeft;
            int budget = 0;

            weekDays -= goesOut; // standart days vs. out
            budget += 150; // rent
            budget += (partyWeekends * 2) * 20;
            budget += (goesOut * percentLeft) + (10 * goesOut);
            budget += weekDays * 10; // normal days

            if (budget > money) Console.WriteLine(
                "No, not enough {0}.", Math.Abs(money - budget));
            else if (budget < money) Console.WriteLine("Yes, leftover {0}.", money - budget);
            else Console.WriteLine("Exact Budget.");
        }
    }
}

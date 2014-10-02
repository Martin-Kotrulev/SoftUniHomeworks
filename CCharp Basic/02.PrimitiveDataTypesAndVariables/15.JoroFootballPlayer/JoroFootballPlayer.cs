using System;
// joro plays only holydays and weekends
// joro plays in half of the holydays

// joro  plays twise in the weekends but not every weekend
// if not tired,  if he is in his hometown - h times

// 52 weekends:
// normal - 2 times
// tired - 1/3 of normal
// in hometown - 1 time
// if year's leap - +3 times non-weekend

// SOLUTION TESTED - 100%
class JoroFootballPlayer
{
    static void Main()
    {
        string t = Console.ReadLine();          // leap or not leap
        int p = int.Parse(Console.ReadLine());  // holydays
        int h = int.Parse(Console.ReadLine());  // hometown weekends

        int totalWeekends = 52;
        float totalPlays = 0;

        if (t == "t") totalPlays += 3;
        totalWeekends -= h;
        totalPlays += h;
        totalPlays += (float)totalWeekends * 2 / 3;
        totalPlays += (float)p / 2;

        Console.WriteLine((int)totalPlays);
    }
}
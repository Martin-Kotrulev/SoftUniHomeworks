using System;
// Vladi plays 2/3 of the holydays
// 48 normal weekends * 1 time
// h times hometown * 1 time
// if year is leap + 15% 
// plays 3/4 of the weekends
// SOLUTION TESTED - 100%

class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        double plays = 0;
        int totalWeekends = 48;

        totalWeekends -= h;
        plays += totalWeekends * ((double)3 / 4);
        plays += p * (double)2 / 3;
        plays += h;

        if (year == "leap") plays += plays * (double)15 / 100;

        Console.WriteLine((int)plays);
    }
}
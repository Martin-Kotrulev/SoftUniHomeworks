using System;
//•	The number h (the required work hours to finish the project) is on the first input line.
//•	The number d (the days available to finish the project) is on the second input line.
//•	The number p (the productivity in percent) is on the third input line.
//SOLUTION TESTED - 100%

class WorkingHours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int workHours = 12;
        double workDays = d - (double)(d * 10) / 100;
        double efficient = Math.Floor(((workDays * workHours) * p) / 100);

        if (efficient >= h) Console.WriteLine("Yes");
        else Console.WriteLine("No");

        Console.WriteLine(efficient - h);
    }
}
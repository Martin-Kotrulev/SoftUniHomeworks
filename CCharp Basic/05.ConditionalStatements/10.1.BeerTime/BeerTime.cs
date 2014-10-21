using System;

class BeerTime
{
    static void Main()
    {
        DateTime myTime;

        try
        {
            myTime = DateTime.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid time!");
            return;
        }
        
        DateTime pmRestrict = DateTime.Parse("01:00 PM");
        DateTime amRestrict = DateTime.Parse("03:00 AM");

        if ((myTime.Hour >= pmRestrict.Hour) &&
            (myTime.Hour < amRestrict.Hour))
        {
            Console.WriteLine("Beer time");
        }
        else Console.WriteLine("Non-beer time");
    }
}
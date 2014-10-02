using System;
/// <summary>
/// Problem 15:
/// Write a program to read your birthday from the console and 
/// print how old you are now and how old you will be after 10 years.
/// </summary>

class AgeAfterTenYears
{
    static int GetCurrentAge(DateTime birthday, DateTime current)
    {
        int currentAge;

        // check if your birthday have passed
        if ((current.Day > birthday.Day) && current.Month == birthday.Month ||
           current.Month > birthday.Month)
        {
            currentAge = current.Year - birthday.Year;
        }
            // if today is your birthday
        else if (current.Day == birthday.Day && current.Month == birthday.Month)
        {
            currentAge = current.Year - birthday.Year;
            Console.WriteLine("Happy birthday!");
        }
        else
        {
            currentAge = current.Year - birthday.Year;
            currentAge--;
        }
        return currentAge;
    }

    static int AfterTenYears(DateTime today, int currentAge)
    {
        int difference = today.AddYears(10).Year - today.Year;
        int ageAfter = currentAge + difference;
        return ageAfter;
    }

    static void Main()
    {
        Console.Write("Enter your birtday in the format DD/MM/YYYY: ");

        // convert input string into DateTime object
        DateTime birthday = Convert.ToDateTime(Console.ReadLine());
        DateTime current = DateTime.Today;

        int currentAge = GetCurrentAge(birthday, current);
        int afterTen = AfterTenYears(current, currentAge);

        // output
        Console.WriteLine("Current age: {0}", currentAge);
        Console.WriteLine("After 10 years you'll be {0} years old.", afterTen);
    }
}


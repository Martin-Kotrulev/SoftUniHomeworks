using System;
//Problem 16.	** – Magic Dates
//Consider we are given a date in format dd-mm-yyyy, e.g. 17-03-2007.
//We calculate the weight of this date by joining together all its digits, 
//multiplying each digit by each of the other digits and finally sum all 
//obtained products. In our case we will have 8-digits: 17032007, so the
//weight is 1*7 + 1*0 + 1*3 + 1*2 + 1*0 + 1*0 + 1*7 + 7*0 + 7*3 + 7*2 + 
//7*0 + 7*0 + 7*7 + 0*3 + 0*2 + 0*0 + 0*0 + 0*7 + 3*2 + 3*0 + 3*0 + 3*7
//+ 2*0 + 2*0 + 2*7 + 0*0 + 0*7 + 0*7 = 144.
//Your task is to write a program that finds all magic dates: 
//dates between two fixed years matching given magic weight. 
//The dates should be printed in increasing order in format 
//dd-mm-yyyy. We use the traditional calendar (years have 12
//months, each having 28, 29, 30 or 31 days, etc.). 
//Years start from 1 January and end in 31 December.

//SOLUTION CHECKED - 100%

class MagicDates
{
    static int magicWeight;
    static int magicCtr = 0;

    static int GetMagicSum(string date)
    {
        int magicSum = 0;

        for (int i = 0; i < date.Length; i++)
        {
            for (int j = i + 1; j < date.Length; j++)
            {
                int x = (int)date[i] - '0';
                int y = (int)date[j] - '0';
                magicSum += x * y;
            }
        }

        return magicSum;
    }

    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
        System.Globalization.CultureInfo.InvariantCulture;

        DateTime startDate = new DateTime();
        DateTime endDate = new DateTime();

        startDate = startDate.AddYears(int.Parse(Console.ReadLine()) - 1);
        endDate = endDate.AddYears(int.Parse(Console.ReadLine()) - 1);
        magicWeight = int.Parse(Console.ReadLine());

        endDate = endDate.AddDays(31 - 1);
        endDate = endDate.AddMonths(12 - 1);


        while (startDate != endDate)
        {
            string date = startDate.ToString("MMddyyyy");

            if (GetMagicSum(date) == magicWeight)
            {
                Console.WriteLine(startDate.ToString("dd-MM-yyyy"));
                magicCtr++;
            }

            startDate = startDate.AddDays(1);
        }

        if (magicCtr == 0) Console.WriteLine("No");
    }
}
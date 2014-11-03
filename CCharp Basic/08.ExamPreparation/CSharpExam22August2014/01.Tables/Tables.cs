using System;

class Tables
{
    static void Main()
    {
        int legs = 0;

        for (int i = 1; i <= 4; i++)
        {
            legs += int.Parse(Console.ReadLine()) * i;
        }

        int tableTops = int.Parse(Console.ReadLine());
        int tablesToBeMade = int.Parse(Console.ReadLine());

        int possibleTables = legs / 4;
        int legsLeft = legs % 4;
        //int topsLeft = 0;

        //if (possibleTables > tableTops)
        //{
        //    legsLeft += (possibleTables - tableTops) * 4;
        //}
        //else if (tableTops > possibleTables)
        //{
        //    topsLeft += tableTops - possibleTables;
        //}
        //else
        //{

        //}
    }
}
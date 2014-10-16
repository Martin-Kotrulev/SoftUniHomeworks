using System;
//SOLUTION TESTED - 100%

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        // building roof
        int roofSize = n / 2 + 1;
        int roofX = 1;
        int roofM = n / 2;

        for (int i = 0; i < roofSize; i++)
        {
            Console.WriteLine("{0}{1}{2}", new string('-', roofM),
                new string('*', roofX), new string('-', roofM) );
            roofX += 2;
            roofM--;
        }
        
        // building floor
        for (int i = 0; i < n; i++)
        {
            string row = new string('*', n - 2);
            Console.WriteLine("|{0}|", row);
        }
    }
}
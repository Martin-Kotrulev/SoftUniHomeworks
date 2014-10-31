using System;
//Nakov wanted to create as much as possible 
//cables of size 5 meters. He had a lot of cables
//of different sizes, e.g. a big roll of 300 meters,
//another big roll of 130 meters and a few small 
//cables of 30 cm, 15 cm and 10 cm. The cables had
//different sizes and was measured in different 
//measures (meters or centimeters). Nakov calculated
//that he needed 2 cm for crimping each RJ45 connector
//and 3 cm for joining each two pieces of cable. It
//was complex to calculate how much cables Nakov 
//can create so he needs your help.
//Write a program that takes as an input a sequence
//of N cables of different sizes and calculates how
//many student cables Nakov can create by first 
//joining them all together, then cut them into 5
//meters and 4 cm, and finally crimp the RJ45 connectors
//to obtain 5 meters long student network cables.
//Calculate also the length of the unused remaining 
//cable. Note that cables shorter than 20 cm in the
//input will be thrown away, so please discard therm.
//Input
//The input data should be read from the console.
//•	At the first line an integer number n specifying
//the number of cables will be given.
//•	At the next 2 * n lines the cables will be given:
//first comes the cable length; second comes the measure.
//The input data will always be valid and in the format
//described. There is no need to check it explicitly.
//Output
//The output should be printed on the console. It 
//should consist of exactly 2 lines:
//•	The first line should hold the number of studen
//t cables.
//•	The second line should hold the length of the 
//remaining cable.
//Constraints
//•	The number n will be integer in the range [1 … 100].
//•	The cable length is integer in the range [1 … 500].
//•	The cable measure is one of the following values: 
//meters, centimeters.
//•	Allowed working time for your program: 0.1 seconds.
//Allowed memory: 16 MB.

// SOLUTION CHECKED - 100%

class StudentCables
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int overallLength = 0; //in cm
        int numberOfCables = n;
        int studentCable = 504;
        int buildedCables = 0;

        for (int i = 0; i < n; i++)
        {
            int currLen = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();

            if (measure == "meters") currLen *= 100;
            else if (measure == "centimeters" &&
                currLen < 20)
            {
                numberOfCables--;
                continue;
            }

            overallLength += currLen;
        }

        overallLength -= 3 * (numberOfCables - 1); // joining lost

        while (overallLength >= studentCable)
        {
            overallLength -= studentCable;
            buildedCables++;
        }

        Console.WriteLine(buildedCables);
        Console.WriteLine(overallLength);
    }
}

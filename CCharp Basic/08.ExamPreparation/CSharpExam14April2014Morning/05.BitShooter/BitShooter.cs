using System;
//Problem 5 – Bit Shooter
//We are given a bit field in the form of 64-bit integer 
//number. We shoot it 3 times. Each shoot has a center 
//and a size. The shoot damages size bits around the shoot 
//center (makes these bits 0). Finally, the bit field is 
//split into left side (bits 63 … 32) and right side 
//(bits 31 … 0). Write a program that calculates how many 
//bits survive (have value 1) after the shoots in the left 
//side and in the right side of the bit field. The bits are 
//numbered as traditionally in programming: from right to 
//left from 0 to 63.

//Input
//The input data should be read from the console. 
//It will consist of exactly 4 lines:
//•	At the first line you will have a 64-bit integer,
//corresponding to the bit field.
//•	At each of the next 3 lines we have 2 numbers: shoot 
//center and shoot size – integers, split by a space.
//The input data will always be valid and in the format
//described. There is no need to check it explicitly.

//Output
//The output should be printed on the console. It 
//should consists of exactly 2 lines:
//•	The first line print "left: …" and the number 
//of alive bits in the left side.
//•	The second line print "right: …" and the number
//of alive bits in the right side.
//Constraints
//•	The bit field will be a 64-bit integer in the 
//range [0 … 18 446 744 073 709 551 615].
//•	The values for the center will be integers 
//will be integers in range [0 … 63].
//•	The values for the size will be odd integers in range [1 … 99].
//•	Allowed working time for your program: 0.25 seconds.
//•	Allowed memory: 16 MB.

// SOLUTION TESTED 100%

class BitShooter
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        ulong shots = 0;
        for (int i = 0; i < 3; i++)
        {
            string[] cin = Console.ReadLine().Trim().Split(' ');
            int shootCenter = int.Parse(cin[0]);
            int dmgArea = int.Parse(cin[1]);

            // building shots
            int dmgAreaStart = shootCenter - dmgArea / 2;
            int dmgAreaEnd = shootCenter + dmgArea / 2;
            for (int bit = dmgAreaStart; bit <= dmgAreaEnd; bit++)
            {
                if (bit >= 0 && bit < 64) shots |= ((ulong)1 << bit);
            }
        }

        //applying shots
        ulong damagedN = n & ~shots;

        int leftSurvivors = 0;
        int rightSurvivors = 0;
        for (int i = 0; i < 32; i++)
            if (((damagedN >> i) & 1) == 1) rightSurvivors++;
        for (int i = 32; i < 64; i++)
            if (((damagedN >> i) & 1) == 1) leftSurvivors++;

        Console.WriteLine("left: {0}", leftSurvivors);
        Console.WriteLine("right: {0}", rightSurvivors);
    }
}
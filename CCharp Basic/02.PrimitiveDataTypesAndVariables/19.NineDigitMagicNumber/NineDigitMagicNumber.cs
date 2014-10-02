using System;
// magic number is number which:
// has 9 digits composed of numbers between 1 - 7 in format abcdefghi
// subnumbers abc, def, ghi difference must be: ghi - def = def - abc = diff
// the sum of all digits in the number must equal 'sum'

// SOLUTION CHECKED -- 100%
class NineDigitMagicNumber
{
    static bool CheckTripled(int tripled)
    {
        string tri = tripled.ToString();
        if (tripled > 777) return false;
        foreach (var digit in tri)
        {
            if (digit < '1' || digit > '7') return false;
        }
        return true;
    }
    static int GetTriSum(int tripled)
    {
        int sum = 0;
        while (tripled > 0)
        {
            sum += tripled % 10;
            tripled /= 10;
        }
        return sum;
    }
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int magicCtr = 0;

        for (int abc = 111; abc <= 777; abc++)
        {
            int def = abc + diff;
            int ghi = def + diff;
            if (GetTriSum(abc) + GetTriSum(def) + GetTriSum(ghi) == sum &&
                CheckTripled(abc) && CheckTripled(def) && CheckTripled(ghi))
            {
                magicCtr++;
                Console.WriteLine("{0}{1}{2}", abc, def, ghi);
            }
        }
        if (magicCtr == 0) Console.WriteLine("No");
    }
}
using System;
// SOLUTION TESTED - 100%

class SumOfElements
{
    static void Main()
    {
        long sum = 0;
        long bigest = int.MinValue;
        char digit;

        do
        {
            digit = (char)Console.Read();
            long number = (digit - '0');
            digit = (char)Console.Read();

            while (digit != 32 && digit != 13)
            {
                number = number * 10 + (digit - '0');
                digit = (char)Console.Read();
            }
            sum += number;
            if (number > bigest) bigest = number;
        } while (digit != 13);

        if (sum == bigest * 2) Console.WriteLine("Yes, sum={0}", bigest);
        else Console.WriteLine("No, diff={0}", Math.Abs(sum - bigest * 2));
    }
}
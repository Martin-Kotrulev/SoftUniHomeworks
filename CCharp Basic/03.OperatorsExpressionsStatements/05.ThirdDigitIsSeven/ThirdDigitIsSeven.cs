using System;
//Write an expression that checks for given 
//integer if its third digit from right-to-left is 7. 
class ThirdDigitIsSeven
{
    static bool CheckThirdDigit(int n)
    {
        int rightmost = 0;
        for (int i = 0; i++ < 3; )
        {
            rightmost = n % 10;
            n /= 10;
        };
        return rightmost == 7;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Third digit 7?\n{0}", CheckThirdDigit(n));
    }
}
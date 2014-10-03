using System;
//The gravitational field of the Moon is approximately 17% 
//of that on the Earth. Write a program that calculates 
//the weight of a man on the moon by a given weight on the Earth.
class GravitationOnMoon
{
    static double GetPercentige(double value, double percentage)
    {
        return (value * percentage / 100);
    }
    static void Main()
    {
        double perc = 17;
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine(GetPercentige(weight, perc));
    }
}
using System;
//Problem 13.	* Comparing Floats
////Write a program that safely compares floating-point numbers 
//(double) with precision eps = 0.000001. Note that we cannot directly 
//compare two floating-point numbers a and b by a==b because of the 
//nature of the floating-point arithmetic. Therefore, we assume 
//two numbers are equal if they are more closely to each other than a fixed constant eps. 

class ComparingFloats
{
    // method returning one extra argument for the difference
    static bool CompareFloats(double first, double second, out double diff)
    {
        bool compare = Math.Abs(first - second) < 1E-6;
        diff = Math.Abs(first - second);
        return compare;
    }
    static void Main()
    {
        Console.WriteLine("Comparing with precision eps = 0.000001:\n");

        double diff;
        bool compare;
        // using array for the numbers
        double[] numbers = new double[12];

        numbers[0] = 5.3;
        numbers[1] = 6.01;
        numbers[2] = 5.00000001;
        numbers[3] = 5.00000003;
        numbers[4] = 5.00000005;
        numbers[5] = 5.00000001;
        numbers[6] = -0.0000007;
        numbers[7] = 0.00000007;
        numbers[8] = -4.999999;
        numbers[9] = -4.999998;
        numbers[10] = 4.999999;
        numbers[11] = 4.999998;

        for (int i = 0; i < numbers.Length; i += 2) // comparing every next two numbers
        {
            compare = CompareFloats(numbers[i], numbers[i + 1], out diff);
            Console.WriteLine("{0, 10} == {1, 10}: {2, 5}; Difference: {3}",
            numbers[i], numbers[i + 1], compare, (decimal)diff); // using decimal cast for correct info
        }
    }
}
using System;
//Problem 10.	Odd and Even Product
//You are given n integers (given in a single line, 
//separated by a space). Write a program that checks
//whether the product of the odd elements is equal
//to the product of the even elements. Elements are
//counted from 1 to n, so the first element is odd, 
//the second is even, etc

class OddOrEvenProduct
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int odd_product = 1;
        int even_product = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if ((i & 1) == 0) even_product *= int.Parse(numbers[i]);
            else odd_product *= int.Parse(numbers[i]);
        }

        if (odd_product == even_product)
        {
            Console.WriteLine("yes\nproduct = {0}", odd_product);
        }
        else Console.WriteLine("no\nodd_product = {0}\neven_product = {1}",
            odd_product, even_product);
    }
}
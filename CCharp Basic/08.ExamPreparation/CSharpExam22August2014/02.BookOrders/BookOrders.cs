using System;
//Problem 2 – Book Orders

//Bai NakMan has his own book store business. 
//He often makes orders for new books, but the 
//procedure is kind of complicated. You will be 
//given the number of orders N. Each order holds,
//number of packets, amount of books per packet 
//and price per book. Depending on the number of 
//packets, you get different discount ranging from 
//5% to 15%.  If the packets in the order are less
//than 10, there is no discount. Otherwise they have
//the following discounts (10-19 packets = 5% discount,
//20-29 = 6%, 30-39 = 7%, ..., 100-109 = 14%). If the
//packets are 110 or more, there is 15% discount for all 
//books. Your task is to sum how many books Bai NakMan has
//bought and the end price of all books. Check the examples 
//below to understand your task better.

//Input
//The input data should be read from the console.
//•	At the first line you will be given integer number
//N representing the number or orders.
//•	At the next 3*N lines you will be given the 
//following inputs:
//o	Book price
//o	Number of packets
//o	Books per packet
//The input data will always be valid and in the format described. 
//There is no need to check it explicitly.

//Output
//The output should be printed on the console. It should
//consist of exactly 2 lines:
//•	On the first line print the amount of all bought books
//•	On the second line print the price of all books 
//bough, rounded to the second number after the decimal point

//Constraints
//•	The number of orders, packets and books per packet 
//will all be integers in range [0…10000].
//•	The book price will always be a floating-point number 
//in range [±5.0 × 10-324 … ±1.7 × 10308].
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.

// SOLUTION CHECKED - 100%

class BookOrders
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double endPrice = 0;
        int booksCount = 0;

        for (int i = 0; i < n; i++)
        {
            int pack = int.Parse(Console.ReadLine());
            int amount = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int currentCount = pack * amount;
            double discount = 0;

            if (pack >= 10 && pack < 110) discount = pack / 10 + 4;
            else if (pack >= 110) discount = 15;

            double currentPrice = price * (100 - discount) / 100;
            endPrice += currentPrice * currentCount;
            booksCount += currentCount;
        }

        Console.WriteLine(booksCount);
        Console.WriteLine("{0:F2}", endPrice);
    }
}
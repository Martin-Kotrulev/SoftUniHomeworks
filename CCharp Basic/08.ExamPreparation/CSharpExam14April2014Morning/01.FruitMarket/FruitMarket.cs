using System;
//Problem 1 – Fruit Market
//The local fruit market offers fruits and vegetables
//with the following standard price list:
//•	banana  1.80
//•	cucumber  2.75
//•	tomato  3.20
//•	orange  1.60
//•	apple  0.86	The market owner decided to
//introduce the following discounts:
//•	Friday  10% off for all products
//•	Sunday  5% off for all products
//•	Tuesday  20% off for fruits
//•	Wednesday  10% off for vegetables
//•	Thursday  30% off for bananas
//Write a program that helps the fruit market owner
//to calculate the total price for orders that 
//consist of day, 3 products with quantities.

//Input
//The input data should be read from the console.
//The input data consists of exactly 7 lines:
//•	At the first line you will be given the day of week. 
//•	At the next 6 lines you will be given: quantity1,
//product1, quantity2, product2, quantity3, product3.
//The input data will always be valid and in the format
//described. There is no need to check it explicitly.

//Output
//You have to print at the console the total price for 
//the specified 3 products at the specified day of week.

//Constraints
//•	The day of week is one of the values: Monday, 
//Tuesday, Wednesday, Thursday, Friday, Saturday, and Sunday. 
//•	The product quantities (quantity1, quantity2,
//quantity3) will be a number in the range [1…100], 
//with up to 2 digits after the decimal point. The
//will be used "." as decimal separator.
//•	The products names (product1, product2, product3) is
//one of the values: banana, cucumber, tomato, orange, and apple.
//•	The total price should be rounded to exactly 2 digits
//after the decimal point (use "." as decimal separator).
//•	Allowed work time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.

// SOLUTION TESTED - 100%

class FruitMarket
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = 
            System.Globalization.CultureInfo.InvariantCulture;

        string dayOfWeek = Console.ReadLine();
        double discount = GetDiscountOfWeekDay(dayOfWeek);

        double totalPrice = 0;
        for (int i = 0; i < 3; i++)
        {
            double quantity = double.Parse(Console.ReadLine());
            string product = Console.ReadLine();
            
            double productPrice = GetProductPrice(product);
            bool isDiscounted = IsDiscounted(product, dayOfWeek);

            double currentPrice = productPrice * quantity;
            if (isDiscounted) currentPrice *= (100 - discount) / 100;
            totalPrice += currentPrice;
        }

        Console.WriteLine("{0:F2}", totalPrice);
    }

    private static bool IsDiscounted(string product, string dayOfWeek)
    {
        if (GetDiscountOfWeekDay(dayOfWeek) == 0) return false;
        if (dayOfWeek == "Friday" || dayOfWeek == "Sunday") return true; 
        else if (dayOfWeek == "Tuesday" && (product == "banana" ||
            product == "orange" || product == "apple")) return true;
        else if (dayOfWeek == "Thursday" && product == "banana") return true;
        else if (dayOfWeek == "Wednesday" &&
            (product == "cucumber" || product == "tomato")) return true;

        return false;
    }

    private static int GetDiscountOfWeekDay(string dayOfWeek)
    {
        switch (dayOfWeek)
        {
            case "Friday": return 10;
            case "Sunday": return 5;
            case "Tuesday": return 20;
            case "Wednesday": return 10;
            case "Thursday": return 30;
        }

        return 0;
    }

    private static double GetProductPrice(string product)
    {
        switch (product)
        {
            case "banana": return 1.80;
            case "cucumber": return 2.75;
            case "tomato": return 3.20;
            case "orange": return 1.60;
            case "apple": return 0.86;
        }

        return 0;
    }
}
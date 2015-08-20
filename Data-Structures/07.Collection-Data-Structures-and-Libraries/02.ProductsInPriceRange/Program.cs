using System;
using Wintellect.PowerCollections;
using System.Diagnostics;
using System.Collections.Generic;

namespace ProductsInPriceRange
{
    /*
     * Products in Price Range
     * Write a program to read a large collection of products (name + price) 
     * and efficiently find the first 20 products in the price range [a…b] 
     * ordered by price. Test for 500 000 products and 10 000 price searches.
     * Hint: you may use OrderedBag<Product> or 
     * OrderedMultiDictionary<int, Product> and sub-ranges.
     */
    class MainClass
    {
        private static OrderedBag<Product> products = new OrderedBag<Product>();

        private static void GenerateProducts()
        {
            Random rand = new Random();
            for (int i = 0; i < 500000; i++)
            {
                var product = new Product(rand.Next(1, 5000), "product " + i);
                products.Add(product);
            }
        }

        private static void PerformSearches(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                int lower = rand.Next(1, 2501);
                int upper = rand.Next(2501, 5001);
                var result = products.Range(
                                 new Product(lower, "lower"), true,
                                 new Product(upper, "upper"), true);

                var first20 = new List<Product>();
                for (int pi = 0; pi < 20; pi++)
                {
                    first20.Add(result[pi]);
                }
            }
        }

        public static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            GenerateProducts();
            Console.WriteLine("Products generation time for 500000 entries:");
            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);

            stopwatch.Restart();
            PerformSearches(10000);
            Console.WriteLine("Time for performing 10000 searches:");
            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);

        }
    }
}

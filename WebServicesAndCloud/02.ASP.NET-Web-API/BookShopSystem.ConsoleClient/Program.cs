using BookShopSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopSystem.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BookShopContext();
            Console.WriteLine(context.Books.Count());
        }
    }
}

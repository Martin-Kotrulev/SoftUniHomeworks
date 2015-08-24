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
            var authorWithBooks = context.Authors;

            foreach (var a in authorWithBooks)
            {
                Console.WriteLine(a.LastName);
                foreach (var b in a.Books)
                {
                    Console.WriteLine(b.Title);
                }
            }
        }
    }
}

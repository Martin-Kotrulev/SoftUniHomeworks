using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FriendBits
{
    class FriendBits
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            int len = 1;
            uint result = 0;
            int start = 0;
            for (int i = 30; i >= 0; i++)
			{
                uint first = n >> (i + 1);
                uint second = n >> i;
                len = first == second ? len + 1 : 1;

			}
        }
    }
}

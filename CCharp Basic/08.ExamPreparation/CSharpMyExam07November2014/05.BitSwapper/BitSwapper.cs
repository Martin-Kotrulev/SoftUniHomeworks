using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitSwapper
{
    class BitSwapper
    {
        static uint[] nums = new uint[4];

        static void Main(string[] args)
        {    
            for (int i = 0; i < nums.Length; i++)
                nums[i] = uint.Parse(Console.ReadLine());

            List<string> commands = new List<string>();
            while (true)
            {
                string current = Console.ReadLine();
                if (current == "End") break;
                else commands.Add(current);
            }

            for (int i = 0; i < commands.Count - 1; i += 2)
            {
                string first = commands[i];
                string second = commands[i + 1];
                int num1 = first[0] - '0';
                int group1 = first[2] - '0';
                int num2 = second[0] - '0';
                int group2 = second[2] - '0';
                SwapBits(num1, group1, num2, group2);
            }

            for (int i = 0; i < nums.Length; i++)
                Console.WriteLine(nums[i]);
        }

        private static void SwapBits(int num1, int group1, int num2, int group2)
        {
            uint mask1 = 0;
            for (int i = group1 * 4 + 3; i >= group1 * 4; i--)
            {
                mask1 <<= 1;
                mask1 |= ((nums[num1] >> i) & 1);
            }
            
            uint mask2 = 0;
            for (int i = group2 * 4 + 3; i >= group2 * 4; i--)
            {
                mask2 <<= 1;
                mask2 |= ((nums[num2] >> i) & 1);
            }
            mask1 <<= group2 * 4;
            mask2 <<= group1 * 4;
            
            // clearing bits on group position
            nums[num1] &= (uint)~(15 << group1 * 4);
            nums[num2] &= (uint)~(15 << group2 * 4);

            // applying the swapped masks
            nums[num1] |= mask2;
            nums[num2] |= mask1;
        }
    }
}

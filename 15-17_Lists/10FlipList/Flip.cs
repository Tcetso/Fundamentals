using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10FlipList
    {
    class Flip
        {
        static void Main(string[] args)
            {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var even = true;
            if (nums.Count%2 != 0)
                {
                even = false;
                }

            var t = nums.Count - 2;
            for (int i = 1; i < (nums.Count/2); i++)
                {
                var temp = nums[i];
                nums[i] = nums[t];
                nums[t] = temp;
                t--;
                }
            Console.WriteLine(string.Join(" ", nums));
            }
        }
    }

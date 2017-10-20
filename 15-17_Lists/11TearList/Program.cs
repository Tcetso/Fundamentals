using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11TearList
    {
    class Program
        {
        static void Main(string[] args)
            {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var split = new List<int>();

            var second = (nums.Count / 2);
            for (int i = 0; i < nums.Count/2; i++)
                {
                split.Add(nums[second] / 10);
                split.Add(nums[i]);
                split.Add(nums[second] % 10);
                second++;
                }
            Console.WriteLine(string.Join(" ", split));
            }
        }
    }

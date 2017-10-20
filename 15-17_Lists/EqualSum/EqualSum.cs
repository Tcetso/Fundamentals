using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSum
{
    class EqualSum
    {
        static void Main(string[] args)
        {
            var nums1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var nums2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < nums1.Count; i++)
            {
                for (int j = 0; j < nums2.Count; j++)
                {
                    if (nums2[j] == nums1[i])
                    {
                        nums2.RemoveAt(j);
                    }
                }
            }
            var sum1 = 0;
            var sum2 = 0;
            SumLists(nums1, nums2, ref sum1, ref sum2);

            if (sum1==sum2)
            {
                Console.WriteLine($"Yes. Sum: {sum1}");
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(sum1-sum2));
            }
            
        }

        private static void SumLists(List<int> nums1, List<int> nums2, ref int sum1, ref int sum2)
        {
            foreach (var number in nums1)
            {
                sum1 += number;
            }
            foreach (var number in nums2)
            {
                sum2 += number;
            }
        }
    }
}

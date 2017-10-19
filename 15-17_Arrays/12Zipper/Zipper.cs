using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Zipper
    {
    class Zipper
        {
        static void Main(string[] args)
            {
            var nums1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var nums2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var tempNums = new List<int>();

            CombineNums(nums1, nums2, tempNums);

            var digits = 0;

            digits = CheckDigits(tempNums, digits);

            RemoveBiggerNumbers(nums1, nums2, digits);

            var finishedNums = new List<int>();

            CombineFinished(nums1, nums2, finishedNums);

            Console.WriteLine(string.Join(" ", finishedNums));

            }

        private static void CombineFinished(List<int> nums1, List<int> nums2, List<int> finishedNums)
            {
            if (nums1.Count > nums2.Count)
                {
                for (int i = 0; i < nums2.Count; i++)
                    {
                    finishedNums.Add(nums2[i]);
                    finishedNums.Add(nums1[i]);
                    }
                for (int i = nums2.Count; i < nums1.Count; i++)
                    {
                    finishedNums.Add(nums1[i]);
                    }
                }
            else if (nums1.Count == nums2.Count)
                {
                for (int i = 0; i < nums2.Count; i++)
                    {
                    finishedNums.Add(nums2[i]);
                    finishedNums.Add(nums1[i]);
                    }
                }
            else
                {
                for (int i = 0; i < nums1.Count; i++)
                    {
                    finishedNums.Add(nums2[i]);
                    finishedNums.Add(nums1[i]);
                    }
                for (int i = nums1.Count; i < nums2.Count; i++)
                    {
                    finishedNums.Add(nums2[i]);
                    }
                }
            }

        private static void RemoveBiggerNumbers(List<int> nums1, List<int> nums2, int digits)
            {
            for (int i = 0; i < nums1.Count; i++)
                {
                if (Math.Abs(nums1[i]) > 9 && Math.Abs(nums1[i]) >= (Math.Pow(10,digits)))
                    {
                    nums1.RemoveAt(i);
                    i--;
                    }
                }
            for (int i = 0; i < nums2.Count; i++)
                {
                if (Math.Abs(nums2[i]) > 9 && Math.Abs(nums2[i]) >= (Math.Pow(10, digits)))
                    {
                    nums2.RemoveAt(i);
                    i--;
                    }
                }
            }

        private static int CheckDigits(List<int> tempNums, int digits)
            {
            while (tempNums[0] > 0)
                {
                tempNums[0] /= 10;
                digits++;
                }

            return digits;
            }

        private static void CombineNums(List<int> nums1, List<int> nums2, List<int> tempNums)
            {
            for (int i = 0; i < nums1.Count; i++)
                {
                tempNums.Add(Math.Abs(nums1[i]));
                }
            for (int i = 0; i < nums2.Count; i++)
                {
                tempNums.Add(Math.Abs(nums2[i]));
                }
            tempNums.Sort();
            }
        }
    }

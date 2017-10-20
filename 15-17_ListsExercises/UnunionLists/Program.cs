using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnunionLists
    {
    class Program
        {
        static void Main(string[] args)
            {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var newlistNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < newlistNumber; i++)
                {
                var currentList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                ExportImportNumbers(nums, currentList);
                }
            nums.Sort();
            Console.WriteLine(string.Join(" ", nums));
            }

        private static void ExportImportNumbers(List<int> nums, List<int> currentList)
            {
            for (int i = 0; i < currentList.Count; i++)
                {
                for (int k = 0; k < nums.Count; k++)
                    {
                    if (currentList[i]==nums[k])
                        {
                        nums.RemoveAll(items => items == currentList[i]);
                        currentList.RemoveAt(i);
                        i--;
                        break;
                        }
                    }
                }
            if (currentList.Count>0)
                {
                for (int i = 0; i < currentList.Count; i++)
                    {
                    nums.Add(currentList[i]);
                    }
                }

            }
        }
    }

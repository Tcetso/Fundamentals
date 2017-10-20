using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDupl
    {
    class Program
        {
        static void Main(string[] args)
            {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count; i++)
                {
                for (int j = i+1; j < nums.Count; j++)
                    {
                    if (nums[j]==nums[i])
                        {
                        nums.RemoveAt(j);
                        j--;
                        }
                    }
                }

            Console.WriteLine(string.Join(" ", nums));
            }
        }
    }

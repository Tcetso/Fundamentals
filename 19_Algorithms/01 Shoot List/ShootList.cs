
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shoot_List
    {
    class Program
        {
        static void Main(string[] args)
            {
            var nums = new List<int>();
            var input = Console.ReadLine();
            var lastRemoved = 0;
            while (input != "stop")
                {
                if (input== "bang")
                    {
                    if (nums.Count == 0)
                        {
                        Console.WriteLine($"nobody left to shoot! last one was {lastRemoved}");
                        Environment.Exit(0);
                        }
                    else if (nums.Count == 1)
                        {
                        lastRemoved = nums[0];
                        Console.WriteLine("shot {0}", lastRemoved);
                        nums.RemoveAt(0);
                        }
                    else
                        {
                        lastRemoved = RemoveAndDecrementElements(nums, lastRemoved);
                        }
                    }

                else
                    {
                    nums.Insert(0, (int.Parse(input)));
                    }
                input = Console.ReadLine();
                }

            if (nums.Count == 0)
                {
                Console.WriteLine($"you shot them all. last one was {lastRemoved}");
                }
            else
                {
                Console.WriteLine("survivors: {0}",string.Join(" ", nums));
                }
            }

        private static int RemoveAndDecrementElements(List<int> nums, int lastRemoved)
            {
            var average = nums.Average();
            for (int i = 0; i < nums.Count; i++)
                {
                if (nums[i] < average)
                    {
                    lastRemoved = nums[i];
                    nums.RemoveAt(i);
                    Console.WriteLine("shot {0}", lastRemoved);
                    break;
                    }
                }
            for (int i = 0; i < nums.Count; i++)
                {
                nums[i]--;
                }

            return lastRemoved;
            }
        }
    }

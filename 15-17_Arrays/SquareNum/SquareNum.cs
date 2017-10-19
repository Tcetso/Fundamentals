using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNum
    {
    class SquareNum
        {
        static void Main(string[] args)
            {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squared = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
                {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                    {
                    squared.Add(numbers[i]);
                    }
                }

            squared.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squared));
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
    {
    class Program
        {
        static void Main()
            {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var positive = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
                {
                if (numbers[i]>0)
                    {
                    positive.Add(numbers[i]);
                    }
                }
            positive.Reverse();
            var output = string.Join(" ", positive);
            if (positive.Count != 0)
                {
                Console.WriteLine(output);
                }
            else
                {
                Console.WriteLine("empty");
                }
            }
        }
    }

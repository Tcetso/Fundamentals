using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNums
    {
    class Program
        {
        static void Main(string[] args)
            {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            numbers.Add(int.MinValue);
            var count = 1;
            for (int i = 0; i < numbers.Count-1; i++)
                {
                if (numbers[i] == numbers[i+1])
                    {
                    count++;
                    }
                else
                    {
                    Console.WriteLine("{0} -> {1}", numbers[i], count);
                    count = 1;
                    }
                }
            }
        }
    }

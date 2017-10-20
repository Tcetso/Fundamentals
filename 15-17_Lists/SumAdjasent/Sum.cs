using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjasent
    {
    class Sum
        {
        static void Main(string[] args)
            {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 1; i < numbers.Count; i++)
                {
                if (numbers[i] == numbers[i-1])
                    {
                    numbers[i] = numbers[i] * 2;
                    numbers.RemoveAt(i-1);
                    if (i>1)
                        {
                        i -= 2;
                        }
                    else
                        {
                        i--;
                        }
                    }
                }
            Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }

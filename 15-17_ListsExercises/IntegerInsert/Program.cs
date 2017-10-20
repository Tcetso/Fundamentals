using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerInsert
    {
    class Program
        {
        static void Main(string[] args)
            {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var current = Console.ReadLine();

            while (current != "end")
                {
                var currentNumber = int.Parse(current);
                var indexNumber = CalculateFirsDigit(currentNumber);
                nums.Insert(indexNumber, currentNumber);

                current = Console.ReadLine();
                }

            Console.WriteLine(string.Join(" ", nums));
            }

        private static int CalculateFirsDigit(int currentNumber)
            {
            var digit = currentNumber;
            while (digit>=10)
                {
                digit /= 10;
                }
            return digit;
            }
        }
    }

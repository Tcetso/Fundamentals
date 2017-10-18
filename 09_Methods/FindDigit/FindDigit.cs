using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigit
	{
	class FindDigitInNum
		{
		static void Main()
			{
			var number = long.Parse(Console.ReadLine());
			var index = int.Parse(Console.ReadLine());

			var digit = FindDigit(number, index);
			Console.WriteLine(digit);
			}

		static int FindDigit(long number, int index)
			{
			var currentIndex = 1;
			while (number > 0)
				{
				if (currentIndex == index)
					{
					return (int)(number % 10);
					}
				else
					{
					currentIndex++;
					number /= 10;
					}
				}
			return (int)(number % 10);
			}
		}

	}
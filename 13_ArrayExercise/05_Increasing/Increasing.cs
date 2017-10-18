using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Increasing
	{
	class Increasing
		{
		static void Main(string[] args)
			{
			var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			bool increasing = true;

			for (int i = 1; i < numbers.Length; i++)
				{
				if (numbers[i] > numbers[i - 1])
					{
					continue;
					}
				else
					{
					increasing = false;
					break;
					}
				}
			if (increasing)
				{
				Console.WriteLine("Yes");
				}
			else Console.WriteLine("No");
			}
		}
	}

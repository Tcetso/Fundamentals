using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CountLarger
	{
	class Larger
		{
		static void Main(string[] args)
			{
			var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			var element = double.Parse(Console.ReadLine());
			var count = 0;

			foreach (var num in numbers)
				{
				if (num > element)
					{
					count++;
					}
				}

			Console.WriteLine(count);
			}
		}
	}

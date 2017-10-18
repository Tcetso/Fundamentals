using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ElementCount
	{
	class Count
		{
		static void Main(string[] args)
			{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var element = int.Parse(Console.ReadLine());
			var count = 0;

			foreach (var num in numbers)
				{
				if (num == element)
					{
					count++;
					}
				}

			Console.WriteLine(count);
			}
		}
	}

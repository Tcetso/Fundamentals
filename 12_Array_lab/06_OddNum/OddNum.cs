using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OddNum
	{
	class OddNum
		{
		static void Main(string[] args)
			{
			var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			for (int i = 0; i < array.Length; i++)
				{
				if (i % 2 != 0 && array[i] % 2 != 0)
					{
					Console.WriteLine($"Index {i} -> {array[i]}");
					}
				}
			}
		}
	}

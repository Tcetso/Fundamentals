using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SumArrayElements
	{
	class Sum
		{
		static void Main(string[] args)
			{
			int n = int.Parse(Console.ReadLine());
			var array = new int[n];

			for (int i = 0; i < array.Length; i++)
				{
				array[i] = int.Parse(Console.ReadLine());
				}

			var sum = 0;

			foreach (var item in array)
				{
				sum += item;
				}

			Console.WriteLine(sum);
			}
		}
	}

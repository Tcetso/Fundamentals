using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyArray
	{
	class Multiply
		{
		static void Main(string[] args)
			{
			var array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			var p = double.Parse(Console.ReadLine());

			for (int i = 0; i < array.Length; i++)
				{
				array[i] *= p;
				}

			Console.WriteLine(string.Join(" ", array));
			}
		}
	}

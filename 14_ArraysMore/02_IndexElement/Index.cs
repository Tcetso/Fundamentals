using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_IndexElement
	{
	class Index
		{
		static void Main(string[] args)
			{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			string output = string.Empty;

			for (int i = 0; i < numbers.Length; i++)
				{
				if (numbers[i] == i)
					{
					output += numbers[i] + " ";
					}
				}
			output = output.Remove(output.Length - 1);
			Console.WriteLine(output);
			}
		}
	}

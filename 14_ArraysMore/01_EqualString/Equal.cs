using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EqualString
	{
	class Equal
		{
		static void Main(string[] args)
			{
			var words = Console.ReadLine().Split(' ');
			var equals = string.Empty;

			for (int i = 2; i < words.Length; i++)
				{
				if (words[i] == words[i - 1] && words[i] == words[i - 2])
					{
					equals = words[i];
					}
				}
			Console.WriteLine($"{equals} {equals} {equals}");
			}
		}
	}

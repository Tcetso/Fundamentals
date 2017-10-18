using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CountCapital
	{
	class Capital
		{
		static void Main(string[] args)
			{
			var strings = Console.ReadLine().Split(' ');
			var count = 0;

			for (int i = 0; i < strings.Length; i++)
				{
				if (strings[i].Length == 1)
					{
					var current = strings[i];

					if (current[0] >= 'A' && current[0] <= 'Z')
						{
						count++;
						}
					}
				}

			Console.WriteLine(count);
			}
		}
	}

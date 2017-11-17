using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_Diamond_Problem
	{
	class diamonds
		{
		static void Main(string[] args)
			{
			string input = Console.ReadLine();

			bool isDiam = false;

			int startIndex = input.IndexOf("<");
			while (startIndex != -1)
				{
				int endIndex;
				string diamond = string.Empty;

				endIndex = input.IndexOf(">", startIndex + 1);

				if (endIndex - startIndex > 0)
					{
					diamond = input.Substring(startIndex + 1, endIndex - startIndex - 1);
					}

				startIndex = input.IndexOf("<", startIndex + 1);

				int sum = 0;
				for (int i = 0; i < diamond.Length; i++)
					{
					if (Char.IsDigit(diamond[i]))
						{
						sum += diamond[i] - '0';
						}
					}
				if (sum > 0)
					{
					Console.WriteLine($"Found {sum} carat diamond");
					isDiam = true;
					}
				}

			if (!isDiam)
				{
				Console.WriteLine("Better luck next time");
				}
			}
		}
	}

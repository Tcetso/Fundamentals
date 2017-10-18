using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CharRotation
	{
	class Rotate
		{
		static void Main(string[] args)
			{
			var letters = Console.ReadLine().ToCharArray();
			var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var output = string.Empty;

			for (int i = 0; i < letters.Length; i++)
				{
				char currentChar;
				if (nums[i] % 2 == 0)
					{
					currentChar = (char)(letters[i] - nums[i]);
					output += currentChar;
					}
				else
					{
					currentChar = (char)(letters[i] + nums[i]);
					output += currentChar;
					}
				}
			Console.WriteLine(output);
			}
		}
	}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Decode_Radio_Frequencies
	{
	class Decode
		{
		static void Main(string[] args)
			{
			var frequencies = Console.ReadLine().Split(' ').ToArray();

			var result = new List<char>();

			for (int i = 0; i < frequencies.Length; i++)
				{
				var letters = frequencies[i].Split('.').Select(int.Parse).ToArray();
				var first = letters[0];
				var second = letters[1];

				if (first>0)
					{
					result.Insert(i, (char)first);
					}
				if (second>0)
					{
					result.Insert(result.Count - i, (char)second);
					}
				}

			Console.WriteLine(string.Join("", result));
			}
		}
	}

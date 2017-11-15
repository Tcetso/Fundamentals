using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_Placeholders
	{
	class Placeholder
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			while (input != "end")
				{
				var items = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
				var sentence = items[0];
					var words = items[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
				for (int i = 0; i < words.Count; i++)
					{
					var replace = "{" + i + "}";
					sentence = sentence.Replace(replace, words[i]);
					}
				Console.WriteLine(sentence);
				input = Console.ReadLine();
				}
			}
		}
	}

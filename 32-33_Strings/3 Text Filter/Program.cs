using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Text_Filter
	{
	class Program
		{
		static void Main(string[] args)
			{
			var ban = Console.ReadLine().Split(new[] {", " },StringSplitOptions.RemoveEmptyEntries);
			string input = Console.ReadLine();
			foreach (var word in ban)
				{
				if (input.Contains(word))
					{
					input = input.Replace(word, new string('*', word.Count()));
					}
				}
			Console.WriteLine(input);
			}
		}
	}

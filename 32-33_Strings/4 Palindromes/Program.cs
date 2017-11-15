using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Palindromes
	{
	class Program
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
			var pals = new HashSet<string>();
			foreach (var word in input)
				{
				char[] reverse = word.ToCharArray();
				Array.Reverse(reverse);
				var item = new string(reverse);
				if (word == item)
					{
					pals.Add(word);
					}
				}
			Console.WriteLine(string.Join(", ", pals.OrderBy(x =>x)));
			}
		}
	}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_Capitalize_Words
	{
	class Capitalize
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine().ToLower();
			while (input!="end")
				{
				var words = input.Split(new[] { '.', '?', '!', ' ', ',', ';', ':', '(', ')', '{', '}', '[', ']', '\\', '/', '-', '+', '#', '"' }, StringSplitOptions.RemoveEmptyEntries);
				for (int i = 0; i < words.Length; i++)
					{
					words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);
					}
				Console.WriteLine(string.Join(", ", words));
				input = Console.ReadLine().ToLower();
				}
			}
		}
	}

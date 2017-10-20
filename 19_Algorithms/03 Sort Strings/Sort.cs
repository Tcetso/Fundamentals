using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sort_Strings
	{
	class Sort
		{
		static void Main(string[] args)
			{
			var words = Console.ReadLine().Split(' ').ToArray();
			var swapped = false;

			do
				{
				swapped = false;
				for (int i = 0; i < words.Length-1; i++)
					{
					var currentWord = words[i];
					var nextWord = words[i + 1];
					if (currentWord.CompareTo(nextWord)>0)
						{
						words[i] = nextWord;
						words[i + 1] = currentWord;
						swapped = true;
						}
					}
				} while (swapped);

			Console.WriteLine(string.Join(" ", words));
			}
		}
	}

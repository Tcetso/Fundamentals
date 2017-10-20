using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Array_Histogram
	{
	class Histogram
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine().Split(' ').ToArray();
			var word = new List<string>();
			var occurences = new List<int>();

			MakeListOfWordsAndCount(input, word, occurences);

			SortLists(word, occurences);

			PrintResult(word, occurences);
			}

		private static void SortLists(List<string> word, List<int> occurences)
			{
			var swap = false;
			do
				{
				swap = false;
				for (int i = occurences.Count-1; i > 0; i--)
					{
					var current = occurences[i];
					var previous = occurences[i - 1];
					if (previous < current)
						{
						Reverse(word, occurences, i, current, previous);
						swap = true;
						}
					}
				} while (swap);
			}

		private static void Reverse(List<string> word, List<int> occurences, int i, int current, int previous)
			{
			occurences[i] = previous;
			occurences[i - 1] = current;
			var temp = word[i];
			word[i] = word[i - 1];
			word[i - 1] = temp;
			}

		private static void PrintResult(List<string> word, List<int> occurences)
			{
			for (int i = 0; i < word.Count; i++)
				{
				double total = occurences.Sum();
				double current = occurences[i];
				double percent = (current / total) * 100;
				Console.WriteLine("{0} -> {1} times ({2:f2}%)", word[i], occurences[i], percent);
				}
			}

		private static void MakeListOfWordsAndCount(string[] input, List<string> word, List<int> occurences)
			{
			foreach (var str in input)
				{
				if (!word.Contains(str))
					{
					word.Add(str);
					occurences.Add(1);
					}
				else
					{
					var index = word.IndexOf(str);
					occurences[index]++;
					}
				}
			}
		}
	}

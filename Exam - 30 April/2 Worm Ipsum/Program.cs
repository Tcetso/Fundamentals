using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Worm_Ipsum
	{
	class Program
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			while (input != "Worm Ipsum")
				{
				var check = input.IndexOf(".");
				bool capital = true;
				if (input[0] < 'A' || input[0] > 'Z')
					{
					capital = false;
					}
				var output = string.Empty;

				if (check == input.Length - 1 && capital)
					{
					var words = input.Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

					for (int i = 0; i < words.Length; i++)
						{
						var word = words[i];
						var letters = new Dictionary<char, int>();
						var newWord = new List<char>();

						foreach (var letter in word)
							{
							if (!letters.ContainsKey(letter))
								{
								letters[letter] = 0;
								}
							letters[letter]++;
							}
						var max = letters.Values.Max();
						if (max > 1)
							{
							var letter = letters.FirstOrDefault(x => x.Value == max).Key;
							for (int z = 0; z < word.Length; z++)
								{
								if (word[z]==',' || word[z] == '-' || word[z] == '[' || word[z] == '\'' || word[z] == '\t' || word[z] == '{' || word[z] == '}' || word[z] == '^')
									{
									newWord.Add(word[z]);
									
									}
								else
									{
									newWord.Add(letter);
									}
								}
							words[i] = new string(newWord.ToArray());
							}
						}
					output = string.Join(" ", words) + ".";
					}

				Console.WriteLine(output);

				input = Console.ReadLine();
				}
			}
		}
	}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _3_Word_Count
	{
	class count
		{
		static void Main(string[] args)
			{
			var words = File.ReadAllText("../../../03. Word Count/words.txt").Split(' ').ToDictionary(x=>x, y=> 0);
			var text = File.ReadAllText("../../../03. Word Count/text.txt").ToLower().Split(new[] { ' ', '-', ',', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (var word in text)
				{
				if (words.ContainsKey(word))
					{
					words[word] += 1;
					}
				}
			foreach (var item in words.OrderByDescending(x=>x.Value))
				{
				File.AppendAllText("../../../03. Word Count/out.txt", string.Format("{0} - {1}{2}", item.Key, item.Value, Environment.NewLine));
				}
			}
		}
	}

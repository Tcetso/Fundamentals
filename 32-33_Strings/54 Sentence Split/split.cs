using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_Sentence_Split
	{
	class split
		{
		static void Main(string[] args)
			{
			var sentence = Console.ReadLine();
			var delimiter = Console.ReadLine();
			var split = sentence.Split(new[] { delimiter }, StringSplitOptions.None);
			Console.WriteLine("["+string.Join(", ", split)+"]");
			}
		}
	}

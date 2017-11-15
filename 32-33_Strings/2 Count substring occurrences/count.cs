using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Count_substring_occurrences
	{
	class count
		{
		static void Main(string[] args)
			{
			var text = Console.ReadLine().ToLower();
			var substr= Console.ReadLine().ToLower();
			var count = 0;
			for (int i = 0; i < (text.Length- substr.Length+1); i++)
				{
				if (substr == string.Empty)
					{
					break;
					}
				var current = text.Substring(i,substr.Length);
				if (current == substr)
					{
					count++;
					}
				}
			Console.WriteLine(count);
			}
		}
	}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Default_Values
	{
	class Program
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var pairs = new Dictionary<string, string>();
			while (input != "end")
				{
				var kvp = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
				pairs[kvp[0]] = kvp[1];
				input = Console.ReadLine();
				}
			var defaultValue = Console.ReadLine();
			var unchangedPairs = pairs.Where(x => x.Value !="null").ToDictionary(x => x.Key, x => x.Value).OrderByDescending(x => x.Value.Length);
			var changedPairs = pairs.Where(x => x.Value == "null").ToDictionary(x => x.Key, x => defaultValue);
			unchangedPairs.ToList().ForEach(x => Console.WriteLine(x.Key + " <-> " + x.Value));
			changedPairs.ToList().ForEach(x => Console.WriteLine(x.Key + " <-> " + x.Value));
			}
		}
	}

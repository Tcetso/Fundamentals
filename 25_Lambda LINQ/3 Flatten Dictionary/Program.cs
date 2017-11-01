using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Flatten_Dictionary
	{
	class Program
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var dictionary = new Dictionary<string, Dictionary<string, string>>();
			while (input != "end")
				{
				var data = input.Split(' ');
				var outerKey = data[0];
				var innerKey = data[1];
				
				if (data[0] != "flatten")
					{
					var value = data[2];
					if (!dictionary.ContainsKey(outerKey))
						{
						dictionary.Add(outerKey, new Dictionary<string, string>());
						}
					dictionary[outerKey][innerKey] = value;
					}
				if (data[0] == "flatten")
					{
					dictionary[innerKey] = dictionary[innerKey].ToDictionary(x => x.Key + x.Value, x => "flattened");
					}
				input = Console.ReadLine();
				}

			var orderedDictionary = dictionary.OrderByDescending(x => x.Key.Length).ToDictionary(x => x.Key, x => x.Value);
			foreach (var item in orderedDictionary)
				{
				Console.WriteLine("{0}", item.Key);
				var inner = item.Value.Where(x => x.Value != "flattened").OrderBy(x => x.Key.Length).ToDictionary(x => x.Key, x => x.Value);
				var flat =item.Value.Where(x => x.Value == "flattened").ToDictionary(x => x.Key, x => x.Value);
				var count = 1;
				foreach (var entry in inner)
					{
					Console.WriteLine($"{count}. {entry.Key} - {entry.Value}");
					count++;
					}
				foreach (var flatEntry in flat)
					{
					Console.WriteLine($"{count}. {flatEntry.Key}");
					count++;
					}
				}
			}
		}
	}

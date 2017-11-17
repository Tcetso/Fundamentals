using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64_Deserialize_String
	{
	class deserialize
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var items = new Dictionary<string, List<int>>();
			while (input != "end")
				{
				var splitInput = input.Split(new[] { ':', '/' }, StringSplitOptions.RemoveEmptyEntries).ToList();
				if (!items.ContainsKey(splitInput[0]))
					{
					items.Add(splitInput[0], new List<int>());
					}
				for (int i = 1; i < splitInput.Count; i++)
					{
					items[splitInput[0]].Add(int.Parse(splitInput[i]));
					}
				input = Console.ReadLine();
				}
			var count = 0;
			foreach (var item in items)
				{
				foreach (var a in item.Value)
					{
					if (count < a)
						{
						count = a;
						}
					}
				}
			var output = string.Empty;
			for (int i = 0; i <= count; i++)
				{
				foreach (var item in items)
					{
					if (item.Value.Contains(i))
						{
						output += item.Key;
						break;
						}
					}
				}
			Console.WriteLine(output);
			}
		}
	}

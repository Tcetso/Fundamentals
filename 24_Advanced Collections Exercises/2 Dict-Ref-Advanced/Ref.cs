using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Dict_Ref_Advanced
	{
	class Ref
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var items = new Dictionary<string, List<int>>();
			while (input != "end")
				{
				var data = input.Split(new string[] { " -> ", ", " }, StringSplitOptions.RemoveEmptyEntries);
				var currentKey = data[0];
				int currentValue= -1;
				if (int.TryParse(data[1], out currentValue))
					{
					if (!items.ContainsKey(currentKey))
						{
						items[currentKey] = new List<int>();
						}
					for (int i = 1; i < data.Length; i++)
						{
						items[currentKey].Add(int.Parse(data[i]));
						}
					}
				else 
					{
					string second = data[1];
					if (items.ContainsKey(data[1]))
						items[currentKey] = new List<int>(items[second]);
					}
				input = Console.ReadLine();
				}

			foreach (var item in items)
				{
				Console.WriteLine("{0} === {1}", item.Key, string.Join(", ", item.Value));
				}
			}
		}
	}

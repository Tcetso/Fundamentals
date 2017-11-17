using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63_Serialize_String
	{
	class serialize
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine().ToCharArray();
			var items = new Dictionary<char, List<int>>();
			for (int i = 0; i < input.Length; i++)
				{
				if (!items.ContainsKey(input[i]))
					{
					items.Add(input[i], new List<int>());
					}
				items[input[i]].Add(i);
				}
			foreach (var character in items)
				{
				Console.WriteLine(character.Key+":"+string.Join("/",character.Value));
				}
			}
		}
	}

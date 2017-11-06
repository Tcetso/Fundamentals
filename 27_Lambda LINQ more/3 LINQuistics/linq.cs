using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LINQuistics
	{
	class linq
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var collections = new Dictionary<string, HashSet<string>>();

			while (input != "exit")
				{
				var commands = input.Split(new[] { '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
				var elementsCount = 0;

				if (commands.Length>1)
					{
					var collectionName = commands[0];
					if (!collections.ContainsKey(collectionName))
						{
						collections.Add(collectionName, new HashSet<string>());
						}
					for (int i = 1; i < commands.Length; i++)
						{
						collections[collectionName].Add(commands[i]);
						}
					}

				else if (int.TryParse(commands[0], out elementsCount))
					{
					var biggest = string.Empty;
					var count = 0;
					foreach (var item in collections)
						{
						if (item.Value.Count > count)
							{
							count = item.Value.Count;
							biggest = item.Key;
							}
						}
					if (count>0)
						{
						foreach (var item in collections[biggest].OrderBy(x => x.Length).Take(elementsCount))
							{
							Console.WriteLine("* {0}", item);
							}
						}
					
					}

				else if (commands.Length == 1 && collections.ContainsKey(commands[0]))
					{
					foreach (var item in collections[commands[0]].OrderByDescending(x => x.Length).ThenByDescending(x => x.Distinct().Count()))
						{
						Console.WriteLine("* {0}", item);
						}
					}
				input = Console.ReadLine();
				}

			var final = Console.ReadLine().Split(' ');
			switch (final[1])
				{
				case "collection":
					foreach (var item in collections.OrderByDescending(x=>x.Value.Count).ThenByDescending(x=> x.Value.Min(y=>y.Count())))
						{
						if (item.Value.Contains(final[0]))
							{
							Console.WriteLine(item.Key);
							}
						}
					break;

				case "all":
					foreach (var item in collections.OrderByDescending(x => x.Value.Count).ThenByDescending(x => x.Value.Min(y => y.Count())))
						{
						if (item.Value.Contains(final[0]))
							{
							Console.WriteLine(item.Key);
							foreach (var metod in item.Value.OrderByDescending(x=>x.Length))
								{
								Console.WriteLine("* {0}", metod);
								}
							}
						}
					break;
				}
			}
		}
	}

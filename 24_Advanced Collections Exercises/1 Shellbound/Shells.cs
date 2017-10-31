using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Shellbound
	{
	class Shells
		{
		static void Main(string[] args)
			{
			var command = Console.ReadLine().Split(' ').ToList();
			var shellData = new Dictionary<string, HashSet<int>>();
			while (command[0] != "Aggregate")
				{
				var city = command[0];
				var shellSize = int.Parse(command[1]);
				if (!shellData.ContainsKey(city))
					{
					shellData.Add(city, new HashSet<int>());
					}
				shellData[city].Add(shellSize);
				command = Console.ReadLine().Split(' ').ToList();
				}

			foreach (var city in shellData)
				{
				int shell = 0;
				if (city.Value.Count==1)
					{
					shell = city.Value.Sum();
					}
				else
					{
					int average = city.Value.Sum() / city.Value.Count;
					shell = city.Value.Sum() - average;
					}
				
				Console.WriteLine("{0} -> {1} ({2})", city.Key, string.Join(", ", city.Value), shell);
				}
			}
		}
	}

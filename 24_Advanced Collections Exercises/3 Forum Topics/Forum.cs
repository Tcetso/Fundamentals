using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Forum_Topics
	{
	class Forum
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var topics = new Dictionary<string, HashSet<string>>();
			while (input != "filter")
				{
				var data = input.Split(new string[] { " -> ", ", " }, StringSplitOptions.RemoveEmptyEntries);
				var key = data[0];
				if (!topics.ContainsKey(key))
					{
					topics.Add(key, new HashSet<string>());
					}
				for (int i = 1; i < data.Length; i++)
					{
					topics[key].Add(data[i]);
					}
				input = Console.ReadLine();
				}
			var filter = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

			foreach (var topic in topics)
				{
				bool containsAll = true;
				var wordsInTopic = topic.Value;
				for (int i = 0; i < filter.Length; i++)
					{
					var filterWord = filter[i];
					if (!wordsInTopic.Contains(filterWord))
						{
						containsAll = false;
						break;
						}
					}
				if (containsAll)
					{
					Console.WriteLine("{0} | #{1}", topic.Key, string.Join(", #", topic.Value));
					}
				}
			}
		}
	}

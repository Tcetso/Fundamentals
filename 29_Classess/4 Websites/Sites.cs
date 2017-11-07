using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Websites
	{
	class Websites
		{
		public string Host { get; set; }
		public string Domain { get; set; }
		public List<string> Queries { get; set; }
		}

	class Sites
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var siteList = new List<Websites>();

			while (input != "end")
				{
				var details = input.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
				var host = details[0];
				var domain = details[1];
				var queries = new List<string>();
				if (details.Count()>2)
					{
					queries = details[2].Split(',').ToList();
					}
				siteList.Add(new Websites {Host=host, Domain=domain, Queries=queries });

				input = Console.ReadLine();
				}

			foreach (var site in siteList)
				{
				string query = string.Join("]&[", site.Queries);
				if (query != string.Empty)
					{
					Console.WriteLine($"https://www.{site.Host}.{site.Domain}/query?=[{query}]");
					}
				else
					{
					Console.WriteLine($"https://www.{site.Host}.{site.Domain}");
					}
				}
			}
		}
	}

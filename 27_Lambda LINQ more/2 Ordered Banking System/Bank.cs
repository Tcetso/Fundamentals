using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ordered_Banking_System
	{
	class Bank
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var accInfo = new Dictionary<string, Dictionary<string, decimal>>();

			while (input != "end")
				{
				var splitInfo = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
				var bank = splitInfo[0];
				var account = splitInfo[1];
				var balance = decimal.Parse(splitInfo[2]);
				if (!accInfo.ContainsKey(bank))
					{
					accInfo.Add(bank, new Dictionary<string, decimal>());
					}
				if (!accInfo[bank].ContainsKey(account))
					{
					accInfo[bank].Add(account, 0);
					}
				accInfo[bank][account] += balance;

				input = Console.ReadLine();
				}

			foreach (var bankinfo in accInfo.OrderByDescending(bank => bank.Value.Sum(acc => acc.Value)).ThenByDescending(bank => bank.Value.Max(acc => acc.Value)))
				{
				foreach (var acc in bankinfo.Value.OrderByDescending(x => x.Value))
					{
					Console.WriteLine($"{acc.Key} -> {acc.Value} ({bankinfo.Key})");
					}
				}
			}
		}
	}

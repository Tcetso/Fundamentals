using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Optimized_Banking_System
	{
	class BankAccounts
		{
		public string Bank { get; set; }
		public string AccountName { get; set; }
		public decimal Balance { get; set; }
		}
	class Banks
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var accounts = new List<BankAccounts>();

			while (input != "end")
				{
				var accParams = input.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
				//var currAcc = new BankAccounts { Bank = accParams[0], AccountName = accParams[1], Balance= decimal.Parse(accParams[2]) };
				accounts.Add(new BankAccounts { Bank = accParams[0], AccountName = accParams[1], Balance = decimal.Parse(accParams[2]) });
				input = Console.ReadLine();
				}

			foreach (var item in accounts.OrderByDescending(x=>x.Balance).ThenBy(x=>x.Bank.Length))
				{
				Console.WriteLine($"{item.AccountName} -> {item.Balance} ({item.Bank})");
				}
			}
		}
	}

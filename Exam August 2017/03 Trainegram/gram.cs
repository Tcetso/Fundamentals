using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03_Trainegram
	{
	class gram
		{
		static void Main(string[] args)
			{
			Regex pattern = new Regex(@"^(<\[\W*\D*\]\.)+(\.\[\w*\d*\]\.)*$"); //^(\<\[[^A-Za-z0-9]*\][\.]{1})+([\.]{1}\[[A-Za-z0-9]*\][\.]{1})*$  for 100/100
			var input = Console.ReadLine();
			var trains = new List<string>();
			while (input!= "Traincode!")
				{
				if (pattern.IsMatch(input))
					{
					trains.Add(input);
					}


				input = Console.ReadLine();
				}
			foreach (var train in trains)
				{
				Console.WriteLine(train);
				}
			}
		}
	}

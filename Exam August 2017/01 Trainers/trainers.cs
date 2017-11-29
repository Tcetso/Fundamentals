using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Trainers
	{
	class Program
		{
		static void Main(string[] args)
			{
			var num = int.Parse(Console.ReadLine());
			var results = new Dictionary<string, float>();
			results.Add("Technical", 0);
			results.Add("Theoretical", 0);
			results.Add("Practical", 0);
			
			for (int i = 0; i < num; i++)
				{
				var distance = float.Parse(Console.ReadLine());
				var cargo = float.Parse(Console.ReadLine());
				var team = Console.ReadLine();
				

				switch (team)
					{
					case "Technical":
						results["Technical"] += (cargo * 1000f * 1.5f) - (0.7f * 2.5f * distance * 1600f);
						break;

					case "Theoretical":
						results["Theoretical"] += (cargo * 1000f * 1.5f) - (0.7f * 2.5f * distance * 1600f);
						break;

					case "Practical":
						results["Practical"] += (cargo * 1000f * 1.5f) - (0.7f * 2.5f * distance * 1600f);
						break;
					}
				}

			float max = results.Max(x => x.Value);
			string winTeam = results.FirstOrDefault(x => x.Value == max).Key;
			Console.WriteLine("The {0} Trainers win with ${1:f3}.", winTeam, max);
			}
		}
	}

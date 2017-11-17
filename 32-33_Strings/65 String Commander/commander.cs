using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65_String_Commander
	{
	class commander
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var command = Console.ReadLine();
			while (command!= "end")
				{
				var param = command.Split(' ');
				switch (param[0])
					{
					case "Right":
						var countLeft = int.Parse(param[1]);
						for (int i = 0; i < countLeft; i++)
							{
							var letter = input.Skip(input.Length - 1).ToArray();
							input = letter[0].ToString() + input.Substring(0, input.Length - 1);
							}
						break;

					case "Left":
						var countRight = int.Parse(param[1]);
						for (int i = 0; i < countRight; i++)
							{
							var letter = input[0];
							input = input.Substring(1)+ letter.ToString();
							}
						break;

					case "Insert":
						var indexIns = int.Parse(param[1]);
						input = input.Substring(0, indexIns ) + param[2] + input.Substring(indexIns);
						break;

					case "Delete":
						var startIndex = int.Parse(param[1]);
						var endIndex = int.Parse(param[2]);
						var part1 = input.Substring(0, startIndex);
						var part2 = input.Substring(endIndex+1);
						input = part1+part2;
						break;
					}
				command = Console.ReadLine();
				}
			Console.WriteLine(input);
			}
		}
	}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Ballistic
	{
	class Ballistic
		{
		static void Main(string[] args)
			{
			var planePosition = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var commands = Console.ReadLine().Split(' ');
			int[] target = new int[2];

			for (int i = 0; i < commands.Length; i++)
				{
				if (i % 2 == 0)
					{
					switch (commands[i])
						{
						case "up":
							target[1] += int.Parse(commands[i + 1]);
							break;
						case "down":
							target[1] -= int.Parse(commands[i + 1]);
							break;
						case "left":
							target[0] -= int.Parse(commands[i + 1]);
							break;
						case "right":
							target[0] += int.Parse(commands[i + 1]);
							break;
						}
					}
				}
			Console.WriteLine($"firing at [{target[0]}, {target[1]}]");

			if (string.Join("", planePosition) == string.Join("", target))
				Console.WriteLine("got 'em!");
			else
				Console.WriteLine("better luck next time...");
			}
		}
	}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Rabbit_Hole
	{
	class Rabbit
		{
		static void Main(string[] args)
			{
			var commands = Console.ReadLine().Split(' ').ToList();
			var energy = int.Parse(Console.ReadLine());
			int currentIndex = 0;
			bool isDeadFromBomb = false;

			while (energy > 0)
				{
				isDeadFromBomb = false;
				string[] currentCommand = commands[currentIndex].Split('|');
				string action = currentCommand[0];

				if (action == "RabbitHole")
					{
					Console.WriteLine("You have 5 years to save Kennedy!");
					break;
					}

				int value = int.Parse(currentCommand[1]);
				switch (action)
					{
					case "Right":
						currentIndex = (currentIndex + value) % commands.Count;
						energy -= value;
						break;
					case "Left":
						currentIndex = Math.Abs(currentIndex - value) % commands.Count;
						energy -= value;
						break;
					case "Bomb":
						commands.RemoveAt(currentIndex);
						currentIndex = 0;
						energy -= value;
						isDeadFromBomb = true;
						break;
					}
				if (commands[commands.Count - 1] != "RabbitHole")
					{
					commands.RemoveAt(commands.Count - 1);
					}
				commands.Add("Bomb|" + energy);
				}

			if (energy <= 0 && isDeadFromBomb)
				{
				Console.WriteLine("You are dead due to bomb explosion!");
				}
			else if (energy <= 0 && !isDeadFromBomb)
				{
				Console.WriteLine("You are tired. You can't continue the mission.");
				}
			}
		}
	}
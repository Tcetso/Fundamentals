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
			//70 from 100 points
			var commands = Console.ReadLine().Split(' ').ToList();
			var energy = int.Parse(Console.ReadLine());
			int currentIndex = 0;
			bool bomb = false;

			while (energy > 0)
				{

				string[] currentObstacle = commands[currentIndex].Split('|');
				string currentCommand = currentObstacle[0];

				if (currentCommand == "RabbitHole")
					{
					Console.WriteLine("You have 5 years to save Kennedy!");
					break;
					}
				else
					{
					int value = int.Parse(currentObstacle[1]);
					switch (currentCommand)
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
							bomb = true;
							break;
						}

					if (commands[commands.Count - 1] != "RabbitHole")
						{
						commands.RemoveAt(commands.Count - 1);
						}
					else
						{
						commands.Add("Bomb|" + energy);
						}
					}

				if (energy <= 0 && bomb)
					{
					Console.WriteLine("You are dead due to bomb explosion!");
					}
				else if (energy <= 0 && !bomb)
					{
					Console.WriteLine("You are tired. You can't continue the mission.");
					}
				}
			}
		}
	}
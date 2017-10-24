using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Japanese_Roulette
	{
	class Roulette
		{
		static void Main(string[] args)
			{
			var cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			var players = Console.ReadLine().Split(' ').ToList();
			int bulletPosition = -1;
			bool dead = false;

			for (int i = 0; i < cylinder.Count; i++)
				{
				if (cylinder[i]==1)
					{
					bulletPosition = i;
					break;
					}
				}

			for (int i = 0; i < players.Count; i++)
				{
				var currentPlayer = players[i].Split(',');
				var playerStr = int.Parse(currentPlayer[0]);
				var direction = currentPlayer[1];

				switch (direction)
					{
					case "Right":
						bulletPosition = (bulletPosition + playerStr) % 6;
						break;
					case "Left":
						bulletPosition = (bulletPosition - playerStr) % 6;
						if (bulletPosition<0)
							{
							bulletPosition += 6;
							}
						break;
					}
				if (bulletPosition == 2)
					{
					Console.WriteLine($"Game over! Player {i} is dead.");
					dead = true;
					break;
					}
				bulletPosition++;
				}
			if (!dead)
				{
				Console.WriteLine("Everybody got lucky!");
				}
			}
		}
	}

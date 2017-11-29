using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Icarus
	{
	class Program
		{
		static void Main(string[] args)
			{
			var planes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			var index = int.Parse(Console.ReadLine());
			var damage = 1;
			var command = Console.ReadLine();
			while (command!= "Supernova")
				{
				var param = command.Split(' ');
				var direction = param[0];
				var steps = int.Parse(param[1]);
				switch (direction)
					{
					case "left":
						for (int i = 1; i <= steps; i++)
							{
							index--;
							if (index<0)
								{
								index = planes.Count-1;
								damage++;
								planes[index] -= damage;
								}
							else
								{
								planes[index] -= damage;
								}
							}
						break;
					case "right":
						for (int i = 1; i <= steps; i++)
							{
							index++;
							if (index > planes.Count - 1)
								{
								index = 0;
								damage++;
								planes[index] -= damage;
								}
							else
								{
								planes[index] -= damage;
								}
							}
						break;
					}
				command = Console.ReadLine();
				}
			Console.WriteLine(string.Join(" ", planes));
			}
		}
	}

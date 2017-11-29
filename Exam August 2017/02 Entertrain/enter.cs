using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Entertrain
	{
	class enter
		{
		static void Main(string[] args)
			{
			var power = int.Parse(Console.ReadLine());
			var wagons = new List<int>();
			var command = Console.ReadLine();
			while (command!= "All ofboard!")
				{
				var currentWagon = int.Parse(command);
				wagons.Add(currentWagon);
				if (wagons.Sum()>power)
					{
					var average = wagons.Sum()/wagons.Count;
					var index = 0;
					var minDiff = int.MaxValue;

					for (int i = 0; i < wagons.Count; i++)
						{
						var current = Math.Abs(wagons[i] - average);
						if (current<minDiff)
							{
							minDiff = current;
							index = i;
							}
						}
					wagons.RemoveAt(index);
					}

				command = Console.ReadLine();
				}
			wagons.Reverse();
			Console.WriteLine(string.Join(" ", wagons) +" {0}",power);
			}
		}
	}

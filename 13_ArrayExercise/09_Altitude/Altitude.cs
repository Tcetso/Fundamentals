using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Altitude
	{
	class Altitude
		{
		static void Main(string[] args)
			{
			var data = Console.ReadLine().Split(' ');

			double altitude = double.Parse(data[0]);
			var direction = string.Empty;
			for (int i = 1; i < data.Length; i++)
				{
				if (i % 2 != 0)
					{
					direction = data[i];
					}
				else
					{
					if (direction == "up")
						{
						altitude += double.Parse(data[i]);
						}
					else
						{
						altitude -= double.Parse(data[i]);
						if (altitude <= 0)
							{
							Console.WriteLine("crashed");
							break;
							}
						}
					}
				}
			if (altitude > 0)
				{
				Console.WriteLine($"got through safely. current altitude: {altitude}m");
				}
			}
		}
	}

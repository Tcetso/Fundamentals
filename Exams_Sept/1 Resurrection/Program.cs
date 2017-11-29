using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Resurrection
	{
	class Program
		{
		static void Main(string[] args)
			{
			var pnoenixes = int.Parse(Console.ReadLine());
			for (int i = 0; i < pnoenixes; i++)
				{
				var lenghtBody = decimal.Parse(Console.ReadLine());
				var widthBody = decimal.Parse(Console.ReadLine());
				var wingLenght = decimal.Parse(Console.ReadLine());
				var totalLenght = (lenghtBody * lenghtBody);
				var totalWing = wingLenght * 2;
				var totalyears = totalLenght * (widthBody + totalWing);
				Console.WriteLine(totalyears);
				}
			}
		}
	}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Wormtest
	{
	class Program
		{
		static void Main(string[] args)
			{
			var length = float.Parse(Console.ReadLine());
			var width = float.Parse(Console.ReadLine());
			length = length * 100;
			var remainder = length % width;
			if (remainder == 0 || float.IsNaN(remainder))
				{
				Console.WriteLine("{0:f2}", length * width);
				}
			else
				{
				var perc = length / width * 100;
				Console.WriteLine("{0:f2}%", perc);
				}
			}
		}
	}

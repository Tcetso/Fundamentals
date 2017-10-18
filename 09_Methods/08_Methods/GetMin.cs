using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
	{
	class GetMinNumber
		{
		static void Main(string[] args)

			{
			var num1 = int.Parse(Console.ReadLine());
			var num2 = int.Parse(Console.ReadLine());
			var num3 = int.Parse(Console.ReadLine());
			var lowest = GetMin(num1, GetMin(num2, num3));
			Console.WriteLine(lowest);

			}
		static int GetMin(int a, int b)
			{
			if (a < b)
				{
				return a;
				}
			return b;
			}

		}
	}

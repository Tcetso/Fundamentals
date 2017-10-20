using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Batteries
	{
	class Battery
		{
		static void Main(string[] args)
			{
			var capacity = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			var consumption = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			var testTime = int.Parse(Console.ReadLine());

			var initialCapacity = new double[capacity.Length];
			for (int i = 0; i < capacity.Length; i++)
				{
				initialCapacity[i] = capacity[i];
				}

			var runTime = new int[capacity.Length];

			RunBatteryTest(capacity, consumption, testTime, runTime);

			PrintResult(capacity, initialCapacity, runTime);
			}

		private static void RunBatteryTest(double[] capacity, double[] consumption, int testTime, int[] runTime)
			{
			for (int i = 0; i < testTime; i++)
				{
				for (int k = 0; k < capacity.Length; k++)
					{
					if (capacity[k] > 0)
						{
						runTime[k]++;
						}
					capacity[k] -= consumption[k];
					}
				}
			}

		private static void PrintResult(double[] capacity, double[] initialCapacity, int[] runTime)
			{
			for (int i = 0; i < capacity.Length; i++)
				{
				if (capacity[i] > 0)
					{
					var remaining = capacity[i] / initialCapacity[i] * 100;
					Console.WriteLine("Battery {0}: {1:f2} mAh ({2:f2})%", (i + 1), capacity[i], remaining);
					}
				else
					{
					Console.WriteLine("Battery {0}: dead (lasted {1} hours)", (i + 1), runTime[i]);
					}
				}
			}
		}
	}

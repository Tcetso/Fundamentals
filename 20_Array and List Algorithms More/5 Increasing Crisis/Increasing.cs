using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Increasing_Crisis
	{
	class Increasing
		{
		static void Main(string[] args)
			{

			//80%

			var lines = int.Parse(Console.ReadLine());
			var output = new List<int>();

			for (int i = 0; i < lines; i++)
				{
				var currentLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
				var startIndex = 0;
				
				if (output.Count>0 && output[output.Count - 1] <= currentLine[0])
					{
					output.AddRange(currentLine);
					}
				else
					{
					for (int k = 0; k < output.Count; k++)
						{
						if (output[k] > currentLine[0])
							{
							startIndex = k;
							break;
							}
						}
					output.InsertRange(startIndex, currentLine);
					}

				for (int t = 1; t < output.Count; t++)
					{
					if (output[t] < output[t - 1])
						{
						var removeCount = (output.Count - t);
						output.RemoveRange(t, removeCount);
						break;
						}
					}
				}

			Console.WriteLine(string.Join(" ", output));
			}
		}
	}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67_Pyramidic
	{
	class pyramid
		{
		static void Main(string[] args)
			{
			var num = int.Parse(Console.ReadLine());
			var inputData = new List<string>();
			var letter = new char();
			var maxCount = 0;
			for (int i = 0; i < num; i++)
				{
				inputData.Add(Console.ReadLine());
				}
			for (int i = 0; i < inputData.Count; i++)
				{
				for (int k = 0; k < inputData[i].Length; k++)
					{
					var currentLetter = inputData[i][k];
					var cols = 1;
					var count = 0;
					for (int z = i+1; z < inputData.Count; z++)
						{
						var checkString = new string(currentLetter, cols + 2);
						if (inputData[z].Contains(checkString))
							{
							cols += 2;
							count++;
							}
						else
							{
							break;
							}
						}
					if (count>maxCount)
						{
						maxCount = count;
						letter = currentLetter;
						}
					}
				}
			var t = 1;
			for (int i = 0; i < maxCount+1; i++)
				{
				Console.WriteLine(new string(letter, i+t));
				t++;
				}
			}
		}
	}

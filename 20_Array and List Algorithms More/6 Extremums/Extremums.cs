using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Extremums
	{
	class Extremums
		{
		static void Main(string[] args)
			{
			var numbers = Console.ReadLine().Split(' ').ToList();
			var type = Console.ReadLine();

			switch (type)
				{
				case "Max":
					for (int i = 0; i < numbers.Count; i++)
						{
						var currentNum = numbers[i];
						var maxNumber = currentNum;
						string lastRotated = currentNum;
						for (int k = 0; k < currentNum.Length; k++)
							{
							var firstDigit = lastRotated[0];
							var rotatedList = new List<char>();
							for (int s = 1; s < maxNumber.Length; s++)
								{
								rotatedList.Add(lastRotated[s]);
								}
							rotatedList.Add(firstDigit);
							lastRotated = string.Join("", rotatedList);
							var rotatedNum = int.Parse(lastRotated);
							if (int.Parse(maxNumber)<rotatedNum)
								{
								maxNumber = lastRotated;
								}
							}
						if (currentNum != maxNumber)
							{
							numbers[i] = maxNumber;
							}
						}
					break;

				case "Min":
					for (int i = 0; i < numbers.Count; i++)
						{
						var currentNum = numbers[i];
						var minNumber = currentNum;
						string lastRotated = currentNum;
						for (int k = 0; k < currentNum.Length; k++)
							{
							var firstDigit = lastRotated[0];
							var rotatedList = new List<char>();
							for (int s = 1; s < minNumber.Length; s++)
								{
								rotatedList.Add(lastRotated[s]);
								}
							rotatedList.Add(firstDigit);
							lastRotated = string.Join("", rotatedList);
							var rotatedNum = int.Parse(lastRotated);
							if (int.Parse(minNumber) > rotatedNum)
								{
								minNumber = lastRotated;
								}
							}
						if (currentNum != minNumber)
							{
							numbers[i] = minNumber;
							}
						}
					break;
				}
			var sum = 0;
			var output = new List<int>();
			for (int i = 0; i < numbers.Count; i++)
				{
				var digit = int.Parse(numbers[i]);
				sum += digit;
				output.Add(digit);
				}
			
			Console.WriteLine(string.Join(", ", output));
			Console.WriteLine(sum);
			}
		}
	}

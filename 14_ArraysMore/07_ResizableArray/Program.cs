using System;
using System.Linq;


namespace MiningCoins_Broken
	{
	class Program
		{
		static void Main()
			{
			int?[] numbers = new int?[4];
			var command = Console.ReadLine().Split(' ');
			while (command[0] != "end")
				{
				int digit = 0;
				if (command[0] == "push" || command[0] == "removeAt")
					{
					digit = int.Parse(command[1]);
					}

				if (command[0] == "push" && numbers[numbers.Length - 1] == null)
					{
					InsertNumber(numbers, digit);
					}
				else if (command[0] == "push" && numbers[numbers.Length - 1] != null)
					{
					int?[] numbersExtended = new int?[numbers.Length * 2];
					for (int i = 0; i < numbers.Length; i++)
						{
						numbersExtended[i] = numbers[i];
						}
					numbers = numbersExtended;
					InsertNumber(numbers, digit);
					}
				else if (command[0] == "removeAt")
					{
					numbers[digit] = null;
					for (int i = digit; i < numbers.Length - 1; i++)
						{
						numbers[i] = numbers[i + 1];
						}
					numbers[numbers.Length - 1] = null;
					}
				else if (command[0] == "pop")
					{
					for (int i = numbers.Length - 1; i >= 0; i--)
						{
						if (numbers[i] != null)
							{
							numbers[i] = null;
							break;
							}
						}
					}
				else if (command[0] == "clear")
					{
					for (int i = 0; i < numbers.Length; i++)
						{
						numbers[i] = null;
						}
					}
				command = Console.ReadLine().Split(' ');
				}
			PrintResult(numbers);
			}

		private static void PrintResult(int?[] numbers)
			{
			int? result = null;
			for (int i = 0; i < numbers.Length; i++)
				{
				if (numbers[i] != null)
					{
					result = numbers[i];
					break;
					}
				}
			if (result == null)
				{
				Console.WriteLine("empty array");
				}
			else
				PrintNotEmpty(numbers);
			}

		private static void PrintNotEmpty(int?[] numbers)
			{
			for (int i = 0; i < numbers.Length; i++)
				{
				if (numbers[i] != null)
					{
					Console.Write(numbers[i] + " ");
					}
				}
			Console.WriteLine();
			}

		private static void InsertNumber(int?[] numbers, int digit)
			{
			for (int i = 0; i < numbers.Length; i++)
				{
				if (numbers[i] == null)
					{
					numbers[i] = digit;
					break;
					}
				}
			}
		}
	}

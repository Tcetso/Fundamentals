using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PhoneExt
	{
	class PhoneExt
		{
		static void Main(string[] args)
			{
			var numbers = Console.ReadLine().Split(' ');
			var names = Console.ReadLine().Split(' ');
			var command = Console.ReadLine().Split(' ');

			while (command[0] != "done")
				{
				var currentNumber = string.Empty;
				var currentName = string.Empty;
				if (command[0] == "call")
					{
					currentNumber = GetNumber(numbers, names, command, currentNumber);
					currentName = GetName(numbers, names, command, currentName);
					if (currentNumber != string.Empty)
						{
						var sumOfDigits = NumberCalculateSum(currentNumber);
						PrintMessageCall(sumOfDigits, currentNumber, currentName, command);
						}
					}
				else if (command[0] == "message")
					{
					currentNumber = GetNumber(numbers, names, command, currentNumber);
					currentName = GetName(numbers, names, command, currentName);
					if (currentNumber != string.Empty)
						{
						var differenceOfDigits = NumberCalculateDifference(currentNumber);
						PrintMessageSMS(differenceOfDigits, currentNumber, currentName, command);
						}
					}
				command = Console.ReadLine().Split(' ');
				}
			}

		private static void PrintMessageCall(int sumOfDigits, string currentNumber, string currentName, string[] command)
			{
			var minutes = sumOfDigits / 60;
			var seconds = sumOfDigits % 60;
			var owner = CallingWho(currentNumber, currentName, command);
			if (sumOfDigits % 2 == 0)
				{
				Console.WriteLine($"calling {owner}...");
				Console.WriteLine($"call ended. duration: 0{minutes}:{seconds}");
				}
			else
				{
				Console.WriteLine($"calling {owner}...");
				Console.WriteLine("no answer");
				}
			}

		private static void PrintMessageSMS(int differenceOfDigits, string currentNumber, string currentName, string[] command)
			{
			var owner = CallingWho(currentNumber, currentName, command);
			if (differenceOfDigits % 2 == 0)
				{
				Console.WriteLine($"sending sms to {owner}...");
				Console.WriteLine("meet me there");
				}
			else
				{
				Console.WriteLine($"sending sms to {owner}...");
				Console.WriteLine("busy");
				}
			}

		private static string CallingWho(string currentNumber, string currentName, string[] command)
			{
			var owner = string.Empty;
			if (command[1] == currentName)
				{
				owner = currentNumber;
				}
			else
				{
				owner = currentName;
				}
			return owner;
			}

		private static string GetNumber(string[] numbers, string[] names, string[] command, string currentNumber)
			{
			for (int i = 0; i < numbers.Length; i++)
				{
				if (command[1] == numbers[i])
					{
					currentNumber = numbers[i];
					break;
					}
				}
			for (int i = 0; i < names.Length; i++)
				{
				if (command[1] == names[i])
					{
					currentNumber = numbers[i];
					break;
					}
				}

			return currentNumber;
			}

		private static string GetName(string[] numbers, string[] names, string[] command, string currentName)
			{
			for (int i = 0; i < numbers.Length; i++)
				{
				if (command[1] == numbers[i])
					{
					currentName = names[i];
					break;
					}
				}
			for (int i = 0; i < names.Length; i++)
				{
				if (command[1] == names[i])
					{
					currentName = names[i];
					break;
					}
				}

			return currentName;
			}

		static int NumberCalculateSum(string num)
			{
			var sum = 0;
			var tempString = string.Empty;
			for (int i = 0; i < num.Length; i++)
				{
				var currentChar = num[i];
				if (char.IsDigit(currentChar))
					{
					tempString += num[i];
					}
				}
			double calc = double.Parse(tempString);
			while (calc > 0)
				{
				double digit = calc % 10;
				sum += (int)digit;
				calc /= 10;
				}
			return sum;
			}

		static int NumberCalculateDifference(string num)
			{
			var sum = 0;
			var tempString = string.Empty;
			for (int i = 0; i < num.Length; i++)
				{
				var currentChar = num[i];
				if (char.IsDigit(currentChar))
					{
					tempString += num[i];
					}
				}
			double calc = double.Parse(tempString);
			while (calc > 0)
				{
				double digit = calc % 10;
				sum -= (int)digit;
				calc /= 10;
				}
			return Math.Abs(sum);
			}

		}
	}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncryption
	{
	class StringEncryption
		{
		static void Main()
			{
			var num = int.Parse(Console.ReadLine());
			var crypted = string.Empty;
			crypted = ReadInput(num, crypted);
			Console.WriteLine(crypted);
			}

		private static string ReadInput(int num, string crypted)
			{
			for (int i = 0; i < num; i++)
				{
				var letter = char.Parse(Console.ReadLine());
				crypted += CryptLetter(letter);
				}

			return crypted;
			}

		static string CryptLetter(char letter)
			{
			int ASCII = letter;
			int lastDigit = ASCII % 10;
			int firstDigit = 0;

			while (ASCII >= 10)
				{
				ASCII /= 10;
				firstDigit = ASCII % 10;
				}

			char front = (char)(letter + lastDigit);
			char back = (char)(letter - firstDigit);
			string result = $"{front}{firstDigit}{lastDigit}{back}";
			return result;
			}
		}
	}

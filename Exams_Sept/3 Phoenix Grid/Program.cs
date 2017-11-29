using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_Phoenix_Grid
	{
	class Program
		{

		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			Regex illegal = new Regex(@"[\s_]");
			while (input != "ReadMe")
				{
				var messageValid = true;
				var phraseValid = false;
				var palidrome = true;
				if (input.Length == 3)
					{
					var reverse = new string(input.ToCharArray().Reverse().ToArray());
					if (illegal.IsMatch(input))
						{
						messageValid = false;
						}
					else if (reverse != input)
						{
						palidrome = false;
						}
					}
				else if (!input.Contains("."))
					{
					messageValid = false;
					}
				else
					{
					var phrases = input.Split('.');
					for (int i = 1; i < phrases.Length; i++)
						{
						if (phrases[i].Length==3&&phrases[i-1].Length==3)
							{
							phraseValid = true;
							break;
							}
						}
					for (int i = 0; i < phrases.Length; i++)
						{
						if (illegal.IsMatch(phrases[i]))
							{
							phraseValid = false;
							break;
							}
						}
					var reverse = new string(input.ToCharArray().Reverse().ToArray());
					if (reverse != input)
						{
						palidrome = false;
						}
					}
				if (messageValid && phraseValid && palidrome)
					{
					Console.WriteLine("YES");
					}
				else
					{
					Console.WriteLine("NO");
					}
				input = Console.ReadLine();
				}
			}
		}
	}

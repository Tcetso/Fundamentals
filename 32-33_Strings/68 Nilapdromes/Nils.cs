using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68_Nilapdromes
	{
	class Nils
		{
		static void Main(string[] args)
			{
			var command = Console.ReadLine();
			while (command!= "end")
				{
				var start = command.Substring(0,command.Length/2);
				var end = string.Empty;
				if (command.Length % 2 == 0)
					{
					end = command.Substring(command.Length / 2);
					}
				else
					{
					end = command.Substring(command.Length / 2 + 1);
					}
				var count = start.Length;
				for (int i = 0; i < count; i++)
					{
					if (start==end)
						{
						break;
						}
					start = start.Substring(0,start.Length-1);
					end = end.Substring(1);
					}
				if (start==end && start!= string.Empty)
					{
					var mid = start;
					var side = command.Substring(start.Length, command.Length - start.Length*2);
					Console.WriteLine(side + mid + side);
					}
				command = Console.ReadLine();
				}
			}
		}
	}

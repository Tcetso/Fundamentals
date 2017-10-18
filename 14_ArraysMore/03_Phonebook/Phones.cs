using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Phonebook
	{
	class Phones
		{
		static void Main(string[] args)
			{
			var numbers = Console.ReadLine().Split(' ');
			var names = Console.ReadLine().Split(' ');

			var currentName = Console.ReadLine();
			while (currentName != "done")
				{
				for (int i = 0; i < names.Length; i++)
					{
					if (currentName == names[i])
						{
						Console.WriteLine(names[i] + " -> " + numbers[i]);
						break;
						}
					}
				currentName = Console.ReadLine();
				}
			}
		}
	}

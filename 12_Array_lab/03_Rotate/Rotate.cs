using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Rotate
	{
	class Rotate
		{
		static void Main(string[] args)
			{
			var array = Console.ReadLine().Split(' ');
			var modifiedArray = new string[array.Length];

			modifiedArray[0] = array[array.Length - 1];
			for (int i = 1; i < array.Length; i++)
				{
				modifiedArray[i] = array[i - 1];
				}

			Console.WriteLine(string.Join(" ", modifiedArray));
			}
		}
	}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Mirror_Image
	{
	class Program
		{
		static void Main(string[] args)
			{
			var numbers = Console.ReadLine().Split(' ').ToList();
			var element = Console.ReadLine();
			while (element != "Print")
				{
				var index = int.Parse(element);
				for (int i = 0; i < (index)/2; i++)
					{
					var temp = numbers[i];
					numbers[i] = numbers[(index - 1) - i];
					numbers[(index - 1) - i] = temp;
					}
				var j = 0;
				for (int i = index+1; i <= (index+numbers.Count)/ 2; i++)
					{
					var temp = numbers[i];
					numbers[i] = numbers[(numbers.Count - 1) - j];
					numbers[(numbers.Count - 1) - j] = temp;
					j++;
					}
				element = Console.ReadLine();
				}
			Console.WriteLine(string.Join(" ", numbers));
			}
		}
	}

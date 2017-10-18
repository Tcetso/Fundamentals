using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Symmetry
	{
	class Symmetry
		{
		static void Main(string[] args)
			{
			var words = Console.ReadLine().Split(' ');
			var original = string.Join("", words);
			var reversed = string.Join("", words.Reverse());
			if (original == reversed)
				{
				Console.WriteLine("Yes");
				}

			Console.WriteLine("No");
			}
		}
	}

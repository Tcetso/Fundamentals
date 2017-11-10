using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Reverse_string
	{
	class Program
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var output = new string(input.ToCharArray().Reverse().ToArray());
			Console.WriteLine(output);
			}
		}
	}

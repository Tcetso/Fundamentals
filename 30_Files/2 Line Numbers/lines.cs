using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_Odd_Lines
	{
	class LinesNum
		{
		static void Main(string[] args)
			{
			var text = File.ReadAllLines("../../../02. Line Numbers/Input.txt");
			var numbered = new List<string>();
			var num = 1;
			foreach (var item in text)
				{
				numbered.Add(num + ". " + item);
				num++;
				}
			File.AppendAllLines("../../../02. Line Numbers/Out.txt", numbered);
			}
		}
	}

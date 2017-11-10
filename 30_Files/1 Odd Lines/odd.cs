using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_Odd_Lines
	{
	class odd
		{
		static void Main(string[] args)
			{
			var text = File.ReadAllLines("../../../01. Odd Lines/Input.txt");
			var odd = new List<string>();
			for (int i = 1; i < text.Length; i+=2)
				{
				odd.Add(text[i]);
				}
			File.AppendAllLines("../../../01. Odd Lines/Out.txt", odd);
			}
		}
	}

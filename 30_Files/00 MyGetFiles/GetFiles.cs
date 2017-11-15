using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_MyGetFiles
	{
	class GetFiles
		{
		static void Main(string[] args)
			{
			var filesList = Directory.GetFiles(@"c:\Store\20171113\xls\");
			var nums = new List<string>();
			for (int i = 0; i < filesList.Length; i++)
				{
				nums.Add(filesList[i]);
				}
			File.WriteAllLines(@"c:\Store\20171113\clients.txt", nums);
			}
		}
	}

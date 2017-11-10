using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _0_My_rename
	{
	class Program
		{
		static void Main(string[] args)
			{
			var select = new Regex("-\\d+");
			var filesList = Directory.GetFiles("c:/Store/scan_dogovori/1");
			var nums = new List<string>();
			for (int i = 0; i < filesList.Length; i++)
				{
				var m = select.Match(filesList[i]);
				nums.Add(m.Value);
				}
			File.WriteAllLines("c:/Store/scan_dogovori/files.txt", nums);
			//var nameList = File.ReadAllLines("c:/Store/scan_dogovori/1/contlist.txt");
			//for (int i = 0; i < filesList.Count(); i++)
			//	{
			//	File.Copy(filesList[i], $"c:/Store/scan_dogovori/1/{nameList[i]}.pdf", true);
			//	}
			}
		}
	}

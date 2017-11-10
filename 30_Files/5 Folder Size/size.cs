using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Folder_Size
	{
	class size
		{
		static void Main(string[] args)
			{
			var files = Directory.GetFiles("../../../05. Folder Size/TestFolder");
			double totalSize = 0;
			foreach (var file in files)
				{
				FileInfo info = new FileInfo(file);
				totalSize += info.Length;
				}
			Console.WriteLine(totalSize/1024/1024);
			}
		}
	}

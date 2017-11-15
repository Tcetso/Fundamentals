using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_JSON_parse
	{
	class Student
		{
		public string Name { get; set; }
		public int Age { get; set; }
		public List<int> Grades { get; set; }
		}
	class parse
		{
		static void Main(string[] args)
			{
			string input = Console.ReadLine();
			var students = new List<Student>();
			input = input.Replace("[{", "{").Replace("}]", "}");
			var items = input.Split(new[] { "{", "},{", "}" }, StringSplitOptions.RemoveEmptyEntries);

			for (int i = 0; i < items.Length; i++)
				{
				var data = items[i].Split(new[] { "name:\"", "\",age:", ",grades:[", "]" }, StringSplitOptions.RemoveEmptyEntries);
				var name = data[0];
				var age = int.Parse(data[1]);
				var grades = new List<int>();
				if (data.Length>2)
					{
					var gradesParse = data[2].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
					grades = new List<int>(gradesParse);
					}
				students.Add(new Student {Name=name, Age=age, Grades=grades });
				}

			for (int i = 0; i < students.Count; i++)
				{
				var grades = string.Join(", ", students[i].Grades);
				if (grades== string.Empty)
					{
					grades = "None";
					}
				Console.WriteLine("{0} : {1} -> {2}", students[i].Name, students[i].Age, grades);
				}
			}
		}
	}

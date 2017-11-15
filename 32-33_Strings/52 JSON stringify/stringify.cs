using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_JSON_stringify
	{
	class Student
		{
		public string Name { get; set; }
		public int Age { get; set; }
		public List<int> Grades { get; set; }
		}

	class stringify
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var students = new List<Student>();
			while (input!= "stringify")
				{
				var data = input.Split(new[] { " : ", " -> ", ", ", " ->" }, StringSplitOptions.RemoveEmptyEntries);
				var name = data[0];
				var age = int.Parse(data[1]);
				var grades = data.Skip(2).Select(int.Parse).ToList();
				students.Add(new Student { Name = name, Age = age, Grades = grades });
				input = Console.ReadLine();
				}
			Console.Write("[");
			for (int i = 0; i < students.Count; i++)
				{
				var name = students[i].Name;
				var age = students[i].Age;
				var grade = string.Join(", ",students[i].Grades);
				Console.Write($"{{name:\"{name}\",age:{age},grades:[{grade}]");
				if (i<students.Count-1)
					{
					Console.Write("},");
					}
				else
					{
					Console.Write("}");
					}
				}
			Console.WriteLine("]");
			}
		}
	}

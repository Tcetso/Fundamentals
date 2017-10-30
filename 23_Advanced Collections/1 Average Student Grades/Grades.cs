using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Average_Student_Grades
	{
	class Grades
		{
		static void Main(string[] args)
			{
			var num = int.Parse(Console.ReadLine());
			var studentGrades = new Dictionary<string, List<double>>();

			for (int i = 0; i < num; i++)
				{
				var current = Console.ReadLine().Split(' ').ToList();
				var name = current[0];
				var grade = double.Parse(current[1]);
				if (!studentGrades.ContainsKey(name))
					{
					studentGrades[name] = new List<double>();
					}
				studentGrades[name].Add(grade);
				}

			foreach (var student in studentGrades)
				{
				Console.Write("{0} -> ", student.Key);
				for (int i = 0; i < student.Value.Count; i++)
					{
					Console.Write("{0:f2} ",student.Value[i]);
					}
				Console.WriteLine("(avg: {0:f2})", student.Value.Average());
				}
			}
		}
	}

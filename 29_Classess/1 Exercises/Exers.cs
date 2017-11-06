using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Exercises
	{
	class Exercises
		{
		public string Topic { get; set; }

		public string CourseName { get; set; }

		public string JudgeLink { get; set; }

		public List<string> Problems { get; set; }
		}

	class Exers
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var data = new List<Exercises>();

			while (input != "go go go")
				{
				var courseInfo = input.Split(new[] { " -> ", ", " }, StringSplitOptions.RemoveEmptyEntries);
				var newExerc = new Exercises();
				newExerc.Topic = courseInfo[0];
				newExerc.CourseName = courseInfo[1];
				newExerc.JudgeLink = courseInfo[2];
				newExerc.Problems = courseInfo.Skip(3).ToList();
				data.Add(newExerc);
				input = Console.ReadLine();
				}
			foreach (var exerc in data)
				{
				Console.WriteLine("Exercises: {0}", exerc.Topic);
				Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.", exerc.CourseName);
				Console.WriteLine("Check your solutions here: {0}", exerc.JudgeLink);
				int count = 1;
				foreach (var item in exerc.Problems)
					{
					Console.WriteLine("{0}. {1}", count, item);
					count++;
					}
				}
			}
		}
	}

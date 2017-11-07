using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Animals
	{
	class Dog
		{
		public string Name { get; set; }
		public int Age { get; set; }
		public int NumberOfLegs { get; set; }
		public void ProduceSound()
			{
			Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
			}
		}
	class Cat
		{
		public string Name { get; set; }
		public int Age { get; set; }
		public int IntelligenceQuotient { get; set; }
		public void ProduceSound()
			{
			Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
			}
		}
	class Snake
		{
		public string Name { get; set; }
		public int Age { get; set; }
		public int CrueltyCoefficient { get; set; }
		public void ProduceSound()
			{
			Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
			}
		}


	class Program
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var dogs = new List<Dog>();
			var cats = new List<Cat>();
			var snakes = new List<Snake>();

			while (input != "I'm your Huckleberry")
				{
				var animalInfo = input.Split(' ').ToList();
				if (animalInfo.Count>2)
					{
					AddAnimals(dogs, cats, snakes, animalInfo);
					}
				else
					{
					var name = animalInfo[1];
					MakeSound(dogs, cats, snakes, name);
					}

				input = Console.ReadLine();
				}
			dogs.ForEach(x => Console.WriteLine($"Dog: {x.Name}, Age: {x.Age}, Number Of Legs: {x.NumberOfLegs}"));
			cats.ForEach(x => Console.WriteLine($"Cat: {x.Name}, Age: {x.Age}, IQ: {x.IntelligenceQuotient}"));
			snakes.ForEach(x => Console.WriteLine($"Snake: {x.Name}, Age: {x.Age}, Cruelty: {x.CrueltyCoefficient}"));

			}

		private static void MakeSound(List<Dog> dogs, List<Cat> cats, List<Snake> snakes, string name)
			{
			foreach (var item in dogs)
				{
				if (item.Name == name)
					{
					item.ProduceSound();
					break;
					}
				}
			foreach (var item in cats)
				{
				if (item.Name == name)
					{
					item.ProduceSound();
					break;
					}
				}
			foreach (var item in snakes)
				{
				if (item.Name == name)
					{
					item.ProduceSound();
					break;
					}
				}
			}

		private static void AddAnimals(List<Dog> dogs, List<Cat> cats, List<Snake> snakes, List<string> animalInfo)
			{
			var type = animalInfo[0];
			var age = int.Parse(animalInfo[animalInfo.Count - 2]);
			var param = int.Parse(animalInfo[animalInfo.Count - 1]);
			string name = string.Join(" ", animalInfo.Skip(1).Reverse().Skip(2).Reverse().ToList());

			switch (type)
				{
				case "Dog":
					dogs.Add(new Dog { Name = name, Age = age, NumberOfLegs = param });
					break;

				case "Cat":
					cats.Add(new Cat { Name = name, Age = age, IntelligenceQuotient = param });
					break;

				case "Snake":
					snakes.Add(new Snake { Name = name, Age = age, CrueltyCoefficient = param });
					break;
				}
			}
		}
	}

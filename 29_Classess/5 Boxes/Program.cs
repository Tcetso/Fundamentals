using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Boxes
	{
	class Point
		{
		public int X { get; set; }
		public int Y { get; set; }

		public double Distance(Point p1, Point p2)
			{
			int deltaX = p2.X - p1.X;
			int deltaY = p2.Y - p1.Y;
			return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
			}
		}

	class Box
		{
		public Point UpperLeft { get; set; }
		public Point UpperRight { get; set; }
		public Point BottomLeft { get; set; }
		public Point BottomRight { get; set; }

		public double CalculatePerimeter(double width, double height)
			{
			return (2 * width + 2 * height);
			}
		public double CalculateArea(double width, double height)
			{
			return (width * height);
			}
		}

	class Program
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var boxes = new List<Box>();

			while (input != "end")
				{
				AddBox(input, boxes);

				input = Console.ReadLine();
				}
			foreach (var box in boxes)
				{
				PrintBoxInfo(box);
				}
			}

		private static void PrintBoxInfo(Box box)
			{
			var width = box.UpperLeft.Distance(box.UpperLeft, box.UpperRight);
			var height = box.UpperLeft.Distance(box.UpperLeft, box.BottomLeft);
			var perimeter = box.CalculatePerimeter(width, height);
			var area = box.CalculateArea(width, height);
			Console.WriteLine($"Box: {width}, {height}");
			Console.WriteLine($"Perimeter: {perimeter}");
			Console.WriteLine($"Area: {area}");
			}

		private static void AddBox(string input, List<Box> boxes)
			{
			var dimensions = input.Split(new[] { " | ", ":" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
			var upleft = new Point { X = dimensions[0], Y = dimensions[1] };
			var upright = new Point { X = dimensions[2], Y = dimensions[3] };
			var botleft = new Point { X = dimensions[4], Y = dimensions[5] };
			var botright = new Point { X = dimensions[6], Y = dimensions[7] };
			boxes.Add(new Box { UpperLeft = upleft, UpperRight = upright, BottomLeft = botleft, BottomRight = botright });
			}
		}
	}

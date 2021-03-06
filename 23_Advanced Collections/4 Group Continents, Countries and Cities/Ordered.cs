﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Cities_by_Continent_and_Country
	{
	class OrderedCities
		{
		static void Main(string[] args)
			{
			var num = int.Parse(Console.ReadLine());
			var citiesData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

			for (int i = 0; i < num; i++)
				{
				var input = Console.ReadLine().Split(' ').ToList();
				var continent = input[0];
				var country = input[1];
				var city = input[2];
				if (!citiesData.ContainsKey(continent))
					{
					citiesData[continent] = new SortedDictionary<string, SortedSet<string>>();
					}
				if (!citiesData[continent].ContainsKey(country))
					{
					citiesData[continent][country] = new SortedSet<string>();
					}
				citiesData[continent][country].Add(city);
				}

			var continentsList = citiesData.Keys;
			foreach (var continent in continentsList)
				{
				Console.WriteLine($"{continent}:");

				var countriesList = citiesData[continent].Keys;
				foreach (var country in countriesList)
					{
					var citiesList = citiesData[continent][country];
					Console.WriteLine(" {0} -> {1}", country, string.Join(", ", citiesList));
					}
				}
			}
		}
	}

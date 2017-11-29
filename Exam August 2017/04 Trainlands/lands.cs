using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Trainlands
	{
	class lands
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var trains = new Dictionary<string, Dictionary<string, int>>();

			while (input!= "It's Training Men!")
				{
				if (input.Contains("="))
					{
					var train = input.Split(new[] { " = " }, StringSplitOptions.RemoveEmptyEntries);
					var trainName = train[0];
					var secondTrain = train[1];
					if (trains.ContainsKey(trainName))
						{
						
						trains.Remove(trainName);
						trains.Add(trainName, new Dictionary<string, int>());
						foreach (var wagon in trains[secondTrain])
							{
							trains[trainName][wagon.Key] = wagon.Value;
							//var name = wagon.Key;
							//var power = wagon.Value;
							//	trains[trainName].Add(name, power);
							}

						}
					}

				else
					{
					var train = input.Split(new[] { " -> ", " : " }, StringSplitOptions.RemoveEmptyEntries);

					if (train.Length>2)
						{
						var trainName = train[0];
						var wagon = train[1];
						var power = int.Parse(train[2]);
						if (!trains.ContainsKey(trainName))
							{
							trains.Add(trainName, new Dictionary<string, int>());
							}
						if (!trains[trainName].ContainsKey(wagon))
							{
							trains[trainName].Add(wagon, 0);
							}
						trains[trainName][wagon] = power;
						}
					else
						{
						var trainName = train[0];
						var secondTrain = train[1];
						if (!trains.ContainsKey(trainName))
							{
							trains.Add(trainName, new Dictionary<string, int>());
							}
						foreach (var wagon in trains[secondTrain])
							{
							if (!trains[trainName].ContainsKey(wagon.Key))
								{
								trains[trainName].Add(wagon.Key, 0);
								}
							trains[trainName][wagon.Key] = wagon.Value;
							}
						trains.Remove(secondTrain);

						}
					}
				input = Console.ReadLine();
				}
			foreach (var train in trains.OrderByDescending(x => x.Value.Sum(z=>z.Value)).ThenBy(x => x.Value.Count()))
				{
				Console.WriteLine("Train: {0}", train.Key);
				
				foreach (var wagon in train.Value.ToDictionary(x => x.Key, y => y.Value).OrderByDescending(x=>x.Value))
					{
					Console.WriteLine("###{0} - {1}", wagon.Key, wagon.Value);
					}
				}
			}
		}
	}

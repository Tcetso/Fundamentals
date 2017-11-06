using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Lambada_Expressions
	{
	class Lambdas
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var lambdas = new Dictionary<string, Dictionary<string, string>>();
			while (input != "lambada")
				{
				if (input != "dance")
					{
					var function = input.Split(new string[] { " => ", "." }, StringSplitOptions.RemoveEmptyEntries);
					var selector = function[0];
					var selectorObject = function[1];
					var property = function[2];
					if (!lambdas.ContainsKey(selector))
						{
						lambdas.Add(selector, new Dictionary<string, string>());
						}
					lambdas[selector][selectorObject] = property;
					}
				else
					{
					
						lambdas = lambdas.ToDictionary(selector => selector.Key, x => x.Value
							.ToDictionary(selectorObject => selectorObject.Key,
								selectorObject => selectorObject.Key + "." + selectorObject.Value));
						
					}
				input = Console.ReadLine();
				}
			foreach (var item in lambdas)
				{
				foreach (var obj in item.Value)
					{
					Console.WriteLine($"{item.Key} => {obj.Key}.{obj.Value}");
					}
				
				}
			}
		}
	}

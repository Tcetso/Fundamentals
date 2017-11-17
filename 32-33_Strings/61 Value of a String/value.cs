using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_Value_of_a_String
	{
	class value
		{
		static void Main(string[] args)
			{
			var str = Console.ReadLine().ToCharArray();
			var type = Console.ReadLine();
			var sum = 0;
			for (int i = 0; i < str.Length; i++)
				{
				switch (type)
					{
					case "UPPERCASE":
						if (str[i]>='A' && str[i]<='Z')
							{
							sum += str[i];
							}
						break;
					case "LOWERCASE":
						if (str[i] >= 'a' && str[i] <= 'z')
							{
							sum += str[i];
							}
						break;
					}
				}
			Console.WriteLine("The total sum is: "+sum);
			}
		}
	}

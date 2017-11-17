using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66_Stateless
	{
	class state
		{
		static void Main(string[] args)
			{
			var state = Console.ReadLine();
			while (state!= "collapse")
				{
				var fiction = Console.ReadLine();

				while (fiction!=string.Empty)
					{
					var startindex = state.IndexOf(fiction);
					while (startindex!=-1)
						{
						state = state.Remove(startindex, fiction.Length).Trim();
						startindex = state.IndexOf(fiction);
						}
					if (fiction.Length>1)
						{
						fiction = fiction.Substring(1, fiction.Length - 2);
						}
					else
						{
						fiction = string.Empty;
						}
					}
				if (state == string.Empty)
					{
					Console.WriteLine("(void)");
					}
				else
					{
					Console.WriteLine(state);
					}
				state = Console.ReadLine();
				}

			}
		}
	}

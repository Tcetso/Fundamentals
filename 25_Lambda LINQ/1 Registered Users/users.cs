using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Registered_Users
	{
	class users
		{
		static void Main(string[] args)
			{
			var user = Console.ReadLine();
			var registeredUsers = new Dictionary<string, DateTime>();
			while (user != "end")
				{
				var userinfo = user.Split(new string[] { " -> " }, StringSplitOptions.None);
				var username = userinfo[0];
				var date = DateTime.ParseExact(userinfo[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
				registeredUsers[username] = date;
				user = Console.ReadLine();
				}
			var sortUsers = registeredUsers.Reverse().OrderBy(x =>x.Value).Take(5).OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
			foreach (var item in sortUsers)
				{
				Console.WriteLine(item.Key);
				}
			}
		}
	}

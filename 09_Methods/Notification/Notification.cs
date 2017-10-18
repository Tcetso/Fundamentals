using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
	{
	class Notification
		{
		static void Main()
			{
			var messages = int.Parse(Console.ReadLine());
			for (int i = 0; i < messages; i++)
				{
				var messageType = Console.ReadLine();
				if (messageType == "success")
					{
					var operation = Console.ReadLine();
					var message = Console.ReadLine();
					Console.WriteLine(ShowSuccess(operation, message));
					}
				else if (messageType == "error")
					{
					var operation = Console.ReadLine();
					var code = int.Parse(Console.ReadLine());
					Console.WriteLine(ShowError(operation, code));
					}
				else
					{
					continue;
					}
				}
			}

		static string ShowSuccess(string operation, string message)
			{
			string result = $"Successfully executed {operation}.\n==============================\nMessage: {message}.";
			return result;
			}

		static string ShowError(string operation, int code)
			{
			var reason = string.Empty;
			if (code > 0)
				{
				reason += "Invalid Client Data";
				}
			else
				{
				reason += "Internal System Failure";
				}
			string result = $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: {reason}.";
			return result;
			}
		}
	}

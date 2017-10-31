using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Social_Media_Posts
	{
	class media
		{
		static void Main(string[] args)
			{
			var input = Console.ReadLine();
			var posts = new Dictionary<string, Dictionary<string, string>>();

			while (input != "drop the media")
				{
				var command = input.Split(' ').ToList();
				var postName = command[1];

				switch (command[0])
					{
					case "post":
						if (!posts.ContainsKey(postName))
							{
							posts.Add(postName, new Dictionary<string, string>());
							posts[postName].Add("Likes", "0");
							posts[postName].Add("Dislikes", "0");
							posts[postName].Add("Comments", string.Empty);
							}
						break;

					case "like":
						var countLikes = int.Parse(posts[postName]["Likes"]);
						countLikes++;
						posts[postName]["Likes"] = countLikes.ToString();
						break;

					case "dislike":
						var countDislike = int.Parse(posts[postName]["Dislikes"]);
						countDislike++;
						posts[postName]["Dislikes"] = countDislike.ToString();
						break;

					case "comment":
						var name = command[2];
						command.RemoveRange(0, 3);
						posts[postName]["Comments"] +=  name + ": " + string.Join(" ", command) +"$#%^^^";
						break;
					}
				input = Console.ReadLine();
				}
			foreach (var post in posts)
				{
				var postname = posts[post.Key];
				var comments = postname["Comments"].Split(new string[] { "$#%^^^" }, StringSplitOptions.RemoveEmptyEntries);
				Console.WriteLine("Post: {0} | Likes: {1} | Dislikes: {2}", post.Key, postname["Likes"], postname["Dislikes"]);
				Console.WriteLine("Comments:");
				if (postname["Comments"] == string.Empty)
					{
					Console.WriteLine("None");
					}
				else
					{
					for (int i = 0; i < comments.Length; i++)
						{
						Console.WriteLine("*  {0}", comments[i]);
						}
					}
				}
			}
		}
	}

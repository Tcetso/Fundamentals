using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            var blacklist = Console.ReadLine().Split(' ').ToList();
            var song = Console.ReadLine();
            var files = new List<string>();

            while (song != "end")
            {
                var blacklisted = 0;
                for (int i = 0; i < blacklist.Count; i++)
                {
                    if (song.Contains(blacklist[i]))
                    {
                        blacklisted++;
                    }
                }
                if (blacklisted ==0)
                {
                    files.Add(song);
                }
                song = Console.ReadLine();
            }

            files.Sort();
            for (int i = 0; i < files.Count; i++)
            {
                Console.WriteLine(files[i]);
            }
        }
    }
}

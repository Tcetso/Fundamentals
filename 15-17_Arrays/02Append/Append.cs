using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Append
    {
    class Append
        {
        static void Main(string[] args)
            {
            var lists = Console.ReadLine().Split('|').ToList();
            var output = string.Empty;

            for (int i = 0; i < lists.Count; i++)
                {
                var currentList = lists[i].Split(' ').ToList();
                RemoveEmpty(currentList);
                if (currentList[0] == "")
                    {
                    currentList.RemoveAt(0);
                    }
                output = string.Join(" ", currentList) + " " + output;
                }

            Console.WriteLine(output);
            }

        private static void RemoveEmpty(List<string> currentList)
            {
            for (int j = 1; j < currentList.Count; j++)
                {
                if (currentList[j] == "")
                    {
                    currentList.RemoveAt(j);
                    j--;
                    }
                }
            }
        }
    }

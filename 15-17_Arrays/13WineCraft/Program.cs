using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13WineCraft
    {
    class Program
        {
        static void Main(string[] args)
            {
            var grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var growthDays = int.Parse(Console.ReadLine());

            while (grapes.Count >= growthDays)
                {

                for (int cycle = 0; cycle < growthDays; cycle++)
                    {
                    AddOneToAll(grapes);
                    CheckGreaterGrapes(grapes);
                    }
                RemoveLowerGrapes(grapes, growthDays);
                }
            Console.WriteLine(string.Join(" ", grapes));
            }

        private static void RemoveLowerGrapes(List<int> grapes, int growthDays)
            {
            for (int i = 0; i < grapes.Count; i++)
                {
                if (grapes[i] <= growthDays)
                    {
                    grapes.RemoveAt(i);
                    }
                }
            }

        private static void CheckGreaterGrapes(List<int> grapes)
            {
            for (int i = 1; i < grapes.Count - 1; i++)
                {
                if (grapes[i] > grapes[i - 1] && grapes[i] > grapes[i + 1])
                    {
                    grapes[i]++;
                    grapes[i - 1] -= 2;
                    grapes[i + 1] -= 2;
                    if (grapes[i + 1]<=0 || grapes[i - 1]<=0)
                        {
                        grapes[i]--;
                        }
                    }
                }
            }

        private static void AddOneToAll(List<int> grapes)
            {
            for (int add = 0; add < grapes.Count; add++)
                {
                if (grapes[add]>0)
                    {
                    grapes[add]++;
                    }
                if (grapes[add]<0)
                    {
                    grapes[add] = 0;
                    }
                }
            }
        }
    }

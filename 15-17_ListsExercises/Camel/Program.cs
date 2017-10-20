using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camel
    {
    class Program
        {
        static void Main(string[] args)
            {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var support = int.Parse(Console.ReadLine());
            var count = 0;

            while (nums.Count>support)
                {
                nums.RemoveAt(nums.Count-1);
                nums.RemoveAt(0);
                count++;
                }

            if (count==0)
                {
                Console.WriteLine("already stable: {0}", string.Join(" ", nums));
                }
            else
                {
                Console.WriteLine("{0} rounds{1}remaining: {2}", count, Environment.NewLine, string.Join(" ", nums));
                }
            }
        }
    }

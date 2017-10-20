using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Average_Delimiter
    {
    class Average
        {
        static void Main(string[] args)
            {
            var input = Console.ReadLine().Split(' ').ToArray();

            var combined = string.Join("", input);

            var sum = 0.0;
            var count = 0.0;
            foreach (var character in combined)
                {
                sum += character;
                count++;
                }
            var delimiter = sum / count;
            delimiter = (int)(Math.Floor(delimiter));
            //delimiter = (int)delimiter;
            if (delimiter>= 'a' && delimiter<= 'z')
                {
                delimiter = delimiter - 32;
                }
            var separator = ((char)delimiter).ToString();
            
            Console.WriteLine(string.Join(separator, input));
            
            }
        }
    }

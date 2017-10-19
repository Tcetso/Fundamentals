using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WordsSplit
    {
    class Split
        {
        static void Main(string[] args)
            {
            var words = Console.ReadLine().Split(',', ';', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ').ToList();
            var lowercase = new List<string>();
            var uppercase = new List<string>();
            var mixcase = new List<string>();

            words.RemoveAll(str => String.IsNullOrEmpty(str));

            //for (int i = 0; i < words.Count; i++)
            //    {
            //    if (words[i].Count() == 0)
            //        {
            //        words.RemoveAt(i);
            //        }
            //    }

            for (int i = 0; i < words.Count; i++)
                {
                var uppercaseCount = 0;
                var lowerCount = 0;
                var other = 0;
                
                foreach (var letter in words[i])
                    {
                    if (letter >= 'a' && letter <= 'z')
                        {
                        lowerCount++;
                        }
                    else if (letter >= 'A' && letter <= 'Z')
                        {
                        uppercaseCount++;
                        }
                    else
                        {
                        other++;
                        }
                    }

                if (uppercaseCount > 0 && lowerCount == 0 && other == 0)
                    {
                    uppercase.Add(words[i]);
                    }
                else if (lowerCount > 0 && uppercaseCount == 0 && other == 0)
                    {
                    lowercase.Add(words[i]);
                    }
                else
                    {
                    mixcase.Add(words[i]);
                    }
                }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowercase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixcase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", uppercase));
            }
        }
    }

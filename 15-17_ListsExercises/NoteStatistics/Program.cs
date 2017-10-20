using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteStatistics
    {
    class Program
        {
        static void Main(string[] args)
            {
            var frequency = new List<double> { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392, 415.3, 440, 466.16, 493.88 };
            var note = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var inputNotes = new List<string>();

            var naturals = new List<string>();
            var sharps = new List<string>();

            ConvertToNotes(frequency, note, nums, inputNotes);
            var naturalsSum = 0.0;
            var sharpsSum = 0.0;
            SplitNotes(nums, inputNotes, naturals, sharps, ref naturalsSum, ref sharpsSum);
            PlayTones(nums);
            Console.WriteLine($"Notes: {string.Join(" ", inputNotes)}");
            Console.WriteLine($"Naturals: {string.Join(" ", naturals)}");
            Console.WriteLine($"Sharps: {string.Join(" ", sharps)}");
            Console.WriteLine($"Naturals sum: {naturalsSum}");
            Console.WriteLine($"Sharps sum: {sharpsSum}");

            }

        private static void PlayTones(List<double> nums)
            {
            for (int i = 0; i < nums.Count; i++)
                {
                Console.Beep((int)nums[i], 200);
                }
            }

        private static void SplitNotes(List<double> nums, List<string> inputNotes, List<string> naturals, List<string> sharps, ref double naturalsSum, ref double sharpsSum)
            {
            for (int i = 0; i < inputNotes.Count; i++)
                {
                if (inputNotes[i].Contains("#"))
                    {
                    sharps.Add(inputNotes[i]);
                    sharpsSum += nums[i];
                    }
                else
                    {
                    naturals.Add(inputNotes[i]);
                    naturalsSum += nums[i];
                    }
                }
            }

        private static void ConvertToNotes(List<double> frequency, List<string> note, List<double> nums, List<string> inputNotes)
            {
            for (int i = 0; i < nums.Count; i++)
                {
                for (int k = 0; k < frequency.Count; k++)
                    {
                    if (nums[i] == frequency[k])
                        {
                        inputNotes.Add(note[k]);
                        break;
                        }
                    }
                }
            }
        }
    }

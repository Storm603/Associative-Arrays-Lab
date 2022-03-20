using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurances
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = Console.ReadLine().ToLower().Split().ToArray();

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (string word in array)
            {
                if (!words.ContainsKey(word))
                {
                    words.Add(word, 1);
                }
                else
                {
                    words[word]++;
                }
            }

            foreach (var word in words)
            {
                if (word.Value % 2 == 1)
                {
                    Console.Write(word.Key + " ");
                }
            }

        }
    }
}

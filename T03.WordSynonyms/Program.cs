using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace T03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < inputCount; i++)
            {
                string word = Console.ReadLine();
                string synon = Console.ReadLine();

                if (!synonyms.ContainsKey(word))
                {
                    synonyms.Add(word, new List<string>());
                    synonyms[word].Add(synon);
                }
                else
                {
                    synonyms[word].Add(synon);
                }
            }

            foreach (var synonymous in synonyms)
            {
                Console.WriteLine($"{synonymous.Key} - {string.Join(", ", synonymous.Value)}");
            }

        }
    }
}

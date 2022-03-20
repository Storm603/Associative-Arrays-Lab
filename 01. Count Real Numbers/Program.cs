using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SortedDictionary<int, int> ocurances = new SortedDictionary<int, int>();

            foreach (int number in array)
            {
                if (!ocurances.ContainsKey(number))
                {
                    ocurances.Add(number, 1);
                }
                else
                {
                    ocurances[number]++;
                }
                

            }

            foreach (var ocurance in ocurances)
            {
                Console.WriteLine($"{ocurance.Key} -> {ocurance.Value}");

            }

        }
    }
}

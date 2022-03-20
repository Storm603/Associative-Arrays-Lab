using System;
using System.Linq;

namespace T05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();

            foreach (var word in input)
            {
                Console.WriteLine(word + ' ');
            }
        }
    }
}

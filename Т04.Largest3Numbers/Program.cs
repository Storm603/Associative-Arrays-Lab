using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Т04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] arr1 = arr.OrderByDescending(n => n).ToArray();

            int limit = 3;

            for (int i = 0; i < limit; i++)
            {
                if (arr1.Length < 3)
                {
                    limit = arr1.Length;
                }
                Console.Write(arr1[i] + " ");
            }
        }
    }
}

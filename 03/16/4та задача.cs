using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            arr.Sort();
            for (int i = 0; i < arr.Count; i++)
            {
                int test = arr[i];
                int broj = 0;
                for (int j = 0; j < arr.Count; j++)
                {
                    if (arr[j] == test)
                    {
                        broj++;
                    }
                }
                i--;
                arr = arr.Where(x => x != test).ToList();
                Console.WriteLine($"{test} -> {broj}");
            }
        }
    }
}

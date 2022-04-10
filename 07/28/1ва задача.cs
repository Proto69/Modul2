using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var storage = new SortedDictionary<double, int>();
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            Start(storage, numbers);
        }
        static void Start(SortedDictionary<double, int> dict, double[] numbers)
        {
            foreach (double number in numbers)
            {
                if (dict.ContainsKey(number))
                {
                    dict[number]++;
                }
                else
                {
                    dict.Add(number, 1);
                }
            }

            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}

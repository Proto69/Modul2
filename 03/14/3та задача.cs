using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp150
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> result = new List<int>();
            foreach (int number in nums)
            {
                if (nums.Max() == number || nums.Min() == number) result.Add(number);
            }
            result.Sort();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
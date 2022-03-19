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
            int remove = nums[nums.Count - 1];
            nums = nums.Where(x => x != remove).ToList();
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
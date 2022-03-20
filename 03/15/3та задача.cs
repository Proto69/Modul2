using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp150
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).Where(x => x >= 0).ToList();
            nums.Reverse();
            if (nums.Count == 0) Console.WriteLine("Empty");
            else Console.WriteLine(string.Join(" ", nums));
        }
    }
}
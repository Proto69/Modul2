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
            int bestLength = 0;
            int end = 0;
            int length = 0;
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i+1])
                {
                    length++;
                }
                if (length > bestLength)
                {
                     end = nums[i];
                     bestLength = length;
                    length = 0;
                }
                if (nums[i] != nums[i+1]) length = 0;

            }
            for (int i = 0; i < bestLength + 1; i++)
            {
                result.Add(end);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
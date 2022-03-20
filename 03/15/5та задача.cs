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
            List<int> bombAndPower = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == bombAndPower[0])
                {
                    for (int j = 0; j <= bombAndPower[1]; j++)
                    {
                        try
                        {
                            nums[i + j] = 0;
                        }
                        catch { }
                        try
                        {
                            nums[i - j] = 0;
                        }
                        catch { }
                    }
                }
            }
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
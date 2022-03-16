using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp150
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            double n = nums.Length;
            switch (n % 2 == 0)
            {
                case false:
                    if (n == 1) Console.Write("{ " + nums[0] + " }");
                    else
                    {
                        int index = nums.Length / 2 - 1;
                        int[] result = new int[3];
                        result[0] = nums[index];
                        result[1] = nums[index + 1];
                        result[2] = nums[index + 2];
                        Console.Write("{ " + string.Join(", ", result) + " }");
                    }
                    break;
                case true:
                    int[] result2 = new int[2];
                    int index2 = (nums.Length / 2) - 1;
                    result2[0] = nums[index2];
                    result2[1] = nums[index2 + 1];
                    Console.Write("{ " + string.Join(", ", result2) + " }");
                    break;
            }
        }
    }
}
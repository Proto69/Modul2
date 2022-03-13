using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = int.Parse(Console.ReadLine());
            int[] sum = new int[nums.Length];
            int k = nums[0];
            int k2 = nums[0];
            for (int i = 0; i < count; i++)
            {
                int last = nums[nums.Length - 1];
                for (int j = 0; j < nums.Length-1; j++)
                {
                    k2 = nums[j+1];
                    nums[j+1] = k;
                    k = k2;
                }
                nums[0] = last;
                for (int j = 0; j < nums.Length; j++)
                {
                    sum[j] = sum[j] + nums[j];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
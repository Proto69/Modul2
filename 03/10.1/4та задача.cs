using System;
using System.Linq;

namespace P08_Condense_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i <= nums.Length + 1; i++)
            {
                int[] condensed = new int[nums.Length - 1];
                if (nums.Length == 1)
                {
                    Console.WriteLine(nums[0]);
                    return;
                }
                for (int i1 = 0; i1 < nums.Length - 1; i1++)
                {
                    condensed[i1] = nums[i1] + nums[i1 + 1];
                }
                nums = condensed;


            }
            Console.WriteLine(nums[0]);

        }
    }
}
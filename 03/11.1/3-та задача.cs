using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp150
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            nums[0] = 1;
            for (int i = 1; i < n; i++)
            {
                if (k <= i)
                {
                    int sum = 0;
                    bool value = true;
                    int counter = 0;
                    while (value)
                    {
                        counter++;
                        sum += nums[i - counter];
                        if (counter == k) value = false;
                    }
                    nums[i] = sum;
                }
                else if (k > i)
                {
                    int sum = 0;
                    for (int j = 0; j < i; j++)
                    {
                        sum += nums[j];
                    }
                    nums[i] = sum;
                }
            }
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp150
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split("|").Where(x => x != " ").ToList();
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] = Reverse(nums[i]);
            }
            string a = string.Join(" ", nums);
            nums = a.Split(" ").Where(x => x != "" && x != null && x != " ").Reverse().ToList();
            Console.WriteLine(string.Join(" ", nums));
        }
        static string Reverse(string num1)
        {
            char[] charArray = num1.ToCharArray();
            Array.Reverse(charArray);
            return string.Join("", charArray);
        }
    }
}
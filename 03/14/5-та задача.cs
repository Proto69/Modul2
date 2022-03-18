using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp150
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split(' ').ToList();
            int sum = 0;
            foreach (string num in nums)
            {
                sum += Reverse(num);
            }
            Console.WriteLine(sum);

        }
        static int Reverse(string num1)
        {
            char[] charArray = num1.ToCharArray();
            Array.Reverse(charArray);
            return int.Parse(string.Join("", charArray));
        }
    }
}
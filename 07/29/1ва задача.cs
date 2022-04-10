using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();
            for (int i = 0; i < n; i++)
            {
                nums.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"Sum = {nums.Sum()}");
            Console.WriteLine($"Min = {nums.Min()}");
            Console.WriteLine($"Max = {nums.Max()}");
            Console.WriteLine($"Average = {nums.Average()}");
        }
    }
}

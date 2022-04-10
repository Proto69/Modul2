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
            List<double> nums = 
                Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();
            
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

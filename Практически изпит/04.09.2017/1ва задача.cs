using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 0 && n < 1000)
            {
                for (int i = 0; i < n; i++)
                {
                    long length = int.Parse(Console.ReadLine());
                    double width = double.Parse(Console.ReadLine());
                    long wings = int.Parse(Console.ReadLine()) * 2;
                    CalculateYears(length, width, wings);
                }
            }
        }
        static void CalculateYears(long length, double width, long wings)
        {
            decimal years = (decimal)Math.Pow(length, 2) * (decimal)(width + wings);
            Console.WriteLine(years);
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp150
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            long[] quantity = new long[products.Length];
            quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            double[] price = new double[products.Length];
            price = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
       
            bool userValue = true;
            while (userValue)
            {
                string[] requests = Console.ReadLine().Split(' ').ToArray();
                int indexOfProduct = Array.IndexOf(products, requests[0]);
                if (requests[0].ToLower() == "done")
                {
                    userValue = false;
                }
                else
                {
                    long test = long.Parse(requests[1]);
                    if (indexOfProduct >= price.Length || indexOfProduct >= quantity.Length || test > quantity[indexOfProduct])
                    {
                        Console.WriteLine($"We do not have enough {products[indexOfProduct]}");
                    }
                    else
                    {
                        double result = price[indexOfProduct] * test;
                        Console.WriteLine($"{products[indexOfProduct]} x {test} costs {result}");
                        quantity[indexOfProduct] -= test;
                    }
                }
            }
        }
    }
}
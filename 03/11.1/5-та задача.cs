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

            string[] requests = new string[products.Length];
            bool userValue = true;
            int n = 0;
            while (userValue)
            {
                string test = Console.ReadLine();
                if (test.ToLower() == "done")
                {
                    userValue = false;
                }
                else
                {
                    requests[n] = test;
                    n++;
                }
            }
            requests = requests.Where(x => x != null).ToArray();
            for (int i = 0; i < requests.Length; i++)
            {
                int indexOfProduct = Array.IndexOf(products, requests[i]);
                Console.WriteLine($"{products[indexOfProduct]} costs: {price[indexOfProduct]}; Available quantity: {quantity[indexOfProduct]}");
            }
        }
    }
}
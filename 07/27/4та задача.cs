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
            var storage = new Dictionary<string, double[]>();
            bool isRunnning = true;
            while (isRunnning)
            {
                string[] items = Console.ReadLine().Split(" ").ToArray();
                if (items[0] == "stocked") isRunnning = false;
                Start(storage, items);
            }
        }
        static void Start(Dictionary<string, double[]> shoppingList, string[] items)
        {
            double sum = 0;
            if (items[0] == "stocked")
            {
                foreach (var pair in shoppingList)
                {
                    sum += pair.Value[0] * pair.Value[1];
                    Console.WriteLine($"{pair.Key}: ${pair.Value[0]:F2} * {pair.Value[1]} = ${(pair.Value[0] * pair.Value[1]):F2}");
                }
                for (int i = 0; i < 30; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                Console.WriteLine($"Grand Total: ${sum:F2}");
            }
            else
            {
                if (shoppingList.ContainsKey(items[0]))
                {
                    double[] arr = shoppingList[items[0]];
                    arr[0] = double.Parse(items[1]);
                    arr[1] += double.Parse(items[2]);
                    shoppingList[items[0]] = arr; 
                }
                else
                {
                    shoppingList.Add(items[0], items.Skip(1).Select(double.Parse).ToArray());
                }
            }
        }
    }
}

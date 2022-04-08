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
            var storage = new Dictionary<string, int>();
            bool isRunnning = true;
            string lastMaterial = "";
            while (isRunnning)
            {
                string items = Console.ReadLine();
                if (items == "stop") isRunnning = false;
                lastMaterial = Start(storage, lastMaterial, items);
            }
        }
        static string Start(Dictionary<string,int> mine, string lastMaterial, string items)
        {
            if (items == "stop")
            {
                foreach (var pair in mine)
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
                }
            }
            else
            {
                try
                {
                    int quantity = int.Parse(items);
                    if (mine.ContainsKey(lastMaterial))
                    {
                        mine[lastMaterial] += quantity;
                    }
                    else mine.Add(lastMaterial, quantity);
                }
                catch
                {
                    lastMaterial = items;
                }
            }
            return lastMaterial;
        }
    }
}

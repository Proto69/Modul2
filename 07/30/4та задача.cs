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
            bool isRunnning = true;
            var dict = new Dictionary<string, string>();
            while (isRunnning)
            {
                string name = Console.ReadLine();
                
                if (name == "stop")
                {
                    isRunnning = false;

                    foreach (var pair in dict)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }
                else
                {
                    string[] email = Console.ReadLine().Split('.').ToArray();
                    if (email[email.Length - 1] != "us" && email[email.Length - 1] != "uk")
                    {
                        if (dict.ContainsKey(name))
                        {
                            dict[name] = string.Join(".", email);
                        }
                        else
                        {
                            dict.Add(name, string.Join(".", email));
                        }
                    }
                }
            }
        }
    }
}

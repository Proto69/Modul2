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
            var storage = new Dictionary<string, string>();
            bool isRunnning = true;
            while (isRunnning)
            {
                Start(storage, isRunnning);
            }
        }
        static void Start(Dictionary<string,string> phonebook, bool isRunnning)
        {
            string[] command = Console.ReadLine().Split(" ").ToArray();
            if (command[0] == "A")
            {
                if (phonebook.ContainsKey(command[1]))
                {
                    phonebook[command[1]] = command[2];
                }
                else phonebook.Add(command[1], command[2]);
            }
            else if (command[0] == "S")
            {
                if (phonebook.ContainsKey(command[1]))
                {
                    Console.WriteLine(command[1] + " -> " + phonebook[command[1]]);
                }
                else
                {
                    Console.WriteLine($"Contact {command[1]} does not exist.");
                }
            }
            else if (command[0] == "END") isRunnning = false;
        }
    }
}

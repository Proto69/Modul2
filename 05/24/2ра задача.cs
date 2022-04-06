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
            
            StringBuilder sb = new StringBuilder();
            sb.Append(Console.ReadLine());
            Start(sb);
        }

        static void Start(StringBuilder text)
        {
            string[] command = Console.ReadLine().Split(' ').ToArray();
            switch (command[0].ToLower())
            {
                case "append":
                    command[0] = "";
                    command = command.Where(x => x != "").ToArray();
                    foreach (string word in command)
                    {
                        text = text.Append(word).Append(' ');
                    }
                    Console.WriteLine(text);
                    break;
                case "remove":
                    text.Remove(int.Parse(command[1]), int.Parse(command[2]));
                    Console.WriteLine(text);
                    break;
                case "insert":
                    int index = int.Parse(command[1]);
                    command[0] = "";
                    command[1] = "";
                    command = command.Where(x => x != "").ToArray();
                    for (int i = command.Length - 1; i >= 0; i--)
                    {
                        text = text.Insert(index, command[i]);
                    }
                    text = text.Insert(index, " ");
                    Console.WriteLine(text);
                    break;
                case "replace":
                    text = text.Replace(command[1], command[2]);
                    Console.WriteLine(text);
                    break;
            }
        }
    }
}

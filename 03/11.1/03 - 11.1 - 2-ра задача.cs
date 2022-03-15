using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            if (words.Length > 100 || words.Length < 1)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                bool userValue = true;
                while (userValue)
                {
                    try
                    {
                        string[] command = Console.ReadLine().Split(' ').ToArray();
                        switch (command.Length)
                        {
                            case 1:
                                if (command[0] == "Reverse")
                                {
                                    Array.Reverse(words);
                                }
                                else if (command[0] == "Distinct")
                                {
                                    for (int j = 0; j < words.Length; j++)
                                    {
                                        string test = words[j];
                                        for (int k = j + 1; k < words.Length; k++)
                                        {
                                            if (test == words[k]) words[k] = " ";
                                        }
                                    }
                                    words = words.Where(x => x != " ").ToArray();
                                }
                                else if (command[0] == "END")
                                {
                                    userValue = false;
                                }
                                break;
                            case 3:
                                if (command[0] == "Replace")
                                {
                                    int index = int.Parse(command[1]);
                                    words[index] = command[2];
                                }
                                break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                Console.WriteLine(string.Join(", ", words));
            }
        }
    }
}
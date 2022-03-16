using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            int numberOfLoops = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLoops; i++)
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
                        }
                        break;
                    case >= 3:
                        if (command[0] == "Replace")
                        {
                            int index = int.Parse(command[1]);
                            words[index] = command[2];
                        }
                        break;
                }
            }
            words = words.Where(x => x != " ").ToArray();
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
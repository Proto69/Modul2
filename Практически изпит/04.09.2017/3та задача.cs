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
            bool isRunning = true;

            while (isRunning)
            {
                string[] text = Console.ReadLine().Split(".").ToArray();

                if (text[0] == "ReadMe") isRunning = false;
                else
                {
                    bool check = true;
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i].Length != 3) check = false;
                        string[] test = text[i].Split(' ', '_').ToArray();
                        if (test.Length > 1) check = false;
                        check = Check(text[i], text, check);
                    }
                    if (check) Console.WriteLine("YES");
                    else Console.WriteLine("NO");
                }
            }
        }

        static bool Check(string word, string[] text, bool check)
        {
            bool check1 = false;
            bool check2 = false;
            string newWord = "";

            char[] test = word.ToCharArray();
            test = test.Reverse().ToArray();
            foreach (var letter in test)
            {
                newWord += letter;
            }

            if (newWord == word) check = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == newWord) check2 = true;
            }

            if (check1 == false && check2 == false) check = false;
            return check;
        }

    }
}

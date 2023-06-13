using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Paid")
                {
                    Console.WriteLine(String.Join(Environment.NewLine, names));
                    names.Clear();
                }
                else
                {
                    names.Enqueue(tokens[0]);
                }
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
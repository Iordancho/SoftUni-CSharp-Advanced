using System;
using System.Collections.Generic;

namespace P01_ReverseStringStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Stack<char> reversedText = new Stack<char>(text);

            foreach (var item in reversedText)
            {
                Console.Write(item);
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> indexes = new();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    indexes.Push(i);
                }
                if (expression[i] == ')')
                {
                    int openBracket = indexes.Pop();
                    for (int j = openBracket; j <= i; j++)
                    {
                        Console.Write(expression[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
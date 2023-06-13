using System;
using System.Collections.Generic;
using System.Linq;

namespace _02__Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>(numbers);

            string command;

            while (!String.Equals(command = Console.ReadLine(), "end", StringComparison.OrdinalIgnoreCase))
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                if (String.Equals(action, "add", StringComparison.OrdinalIgnoreCase))
                {
                    int firstNumber = int.Parse(tokens[1]);
                    int secondNumber = int.Parse(tokens[2]);
                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (String.Equals(action, "remove", StringComparison.OrdinalIgnoreCase))
                {
                    int countNums = int.Parse(tokens[1]);

                    if (countNums > stack.Count)
                    {
                        continue;
                    }

                    for (int i = 0; i < countNums; i++)
                    {
                        stack.Pop();
                    }
                }

            }
            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
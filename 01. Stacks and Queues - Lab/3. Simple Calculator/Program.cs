using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            numbers.Reverse();
            Stack<string> stack = new Stack<string>(numbers);


            int result = int.Parse(stack.Pop());

            while (stack.Count > 0)
            {
                string operation = stack.Pop();

                if (operation == "+")
                {
                    result += int.Parse(stack.Pop());
                }
                else if (operation == "-")
                {
                    result -= int.Parse(stack.Pop());
                }

            }
            Console.WriteLine(result);
        }
    }
}
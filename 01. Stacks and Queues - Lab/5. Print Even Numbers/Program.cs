﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 == 0));



            Console.WriteLine(String.Join(", ", queue));

        }
    }
}
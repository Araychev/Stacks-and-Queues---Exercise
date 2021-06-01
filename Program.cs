using System;
using System.Linq;
using System.Collections.Generic;


namespace Stacks_and_Queues___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = commands[0];
            int s = commands[1];
            int x = commands[2];

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            if (stack.Any())
            {
                if (stack.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}

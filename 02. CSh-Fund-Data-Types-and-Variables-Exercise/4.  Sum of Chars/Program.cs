﻿using System;

namespace _4.__Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= lines; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                int number = (int) symbol;
                sum += number;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}

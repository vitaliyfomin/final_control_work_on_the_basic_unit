﻿using System;

class Program
{
    static void Main()
    {
        Console.Clear();

        Console.Write("Введите строки, разделенные пробелом: ");
        string input = Console.ReadLine();
        string[] inputStrings = input.Split(' ');

        string[] shortStrings = FilterShortStrings(inputStrings);

        Console.WriteLine("Результат:");
        foreach (string str in shortStrings)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterShortStrings(string[] inputStrings)
    {
        int count = 0;
        for (int i = 0; i < inputStrings.Length; i++)
        {
            if (inputStrings[i].Length <= 3)
            {
                count++;
            }
        }

        string[] shortStrings = new string[count];
        int currentIndex = 0;

        for (int i = 0; i < inputStrings.Length; i++)
        {
            if (inputStrings[i].Length <= 3)
            {
                shortStrings[currentIndex] = inputStrings[i];
                currentIndex++;
            }
        }

        return shortStrings;
    }
}

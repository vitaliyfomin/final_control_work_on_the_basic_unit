﻿internal class Program
{
    private static void Main(string[] args)
    {
        void InputArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Добавьте {i} элемент в массив: ");
                array[i] = Console.ReadLine();
            }
        }

        int IndexArray(string[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                    result++;
            }
            return result;
        }

        void OutputArray(string[] array,string[] resultArray)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    resultArray[count] = array[i];
                    count++;
                }
            }
        }

        Console.Clear();
        Console.Write("Введите кол-во элементов в массиве: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[n];   
        InputArray(array);
        string[] resultArray = new string[IndexArray(array)];
        OutputArray(array, resultArray);
        Console.WriteLine($"Результат: [{string.Join(", ", array)}] -> [{string.Join(", ", resultArray)}] ");
    }
}
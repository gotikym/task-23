using System;

internal class Program
{
    static void Main(string[] args)
    {
        byte minRandomNumber = 0;
        byte maxRandomNumber = 26;
        byte elements = 30;
        int[] array = new int[elements];
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(minRandomNumber, maxRandomNumber);
            Console.Write(array[i] + " ");
        }

        Console.WriteLine("\n Локальные максимумы:");

        if (array[0] > array[1])
        {
            Console.Write(array[0] + " ");
        }

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i - 1] < array[i] && array[i] > array[i + 1])
            {
                Console.Write(array[i] + " ");
            }
        }

        if (array[elements - 1] > array[elements - 2])
        {
            Console.Write(array[elements - 1] + " ");
        }
    }
}

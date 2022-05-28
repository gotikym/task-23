using System;

internal class Program
{
    static void Main(string[] args)
    {
        int [] array = new int [30];
        Random rand = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(0,25);
            Console.Write(array[i] + " ");
        }

        Console.WriteLine("\n Локальные максимумы:");
        
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                if (array[i] > array[i+1])
                {
                    Console.Write(array[i] + " ");
                }
            }

            else if (i == array.Length - 1)
            {
                if (array[i] > array[i - 1])
                {
                    Console.Write(array[i] + " ");
                }
            }

            else if (array[i - 1] < array[i] && array[i] > array [i + 1] )
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[30];
        Random rand = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(0, 101);
        }
        Console.WriteLine("Массив:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.Write("Локальные максимумы:");
        if (array[0] >= array[1])
            Console.Write(array[0] + " ");
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
                Console.Write(array[i] + " ");
        }
        if (array.Length - 1 >= array.Length - 2)
        { // проверка последнего элемента
            Console.Write(array[array.Length - 1] + " ");
        }
    }
}
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Размер массива вводим через консоль

Console.WriteLine("Ввод размера массива");
int size = int.Parse(Console.ReadLine()!);

int[] array = FillArray(size, 100, 999);

PrintArray(array);

int evenCounter = CountEvenNumber(array);
Console.WriteLine(evenCounter);

int[] FillArray(int lengthArray, int min, int max)
{
    int[] array = new int[lengthArray];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountEvenNumber(int[] array)
{
    int evenNumberCounter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            evenNumberCounter++;
    }
    return evenNumberCounter;
}


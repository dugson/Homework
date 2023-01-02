// массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// Размер массива, минимальное значение и максимальное значение вводим через консоль

Console.WriteLine("Ввод размера массива");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввод минимального значения");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввод максимального значения");
int max = int.Parse(Console.ReadLine()!);

int[] array = FillArray(size, min, max);

PrintArray(array);

int sumOddIndex = OddIndexSumma(array);
Console.WriteLine(sumOddIndex);

int[] FillArray(int lengthArray, int minValue, int maxValue)
{
    int[] array = new int[lengthArray];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
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

int OddIndexSumma(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Размер массива, минимальное значение и максимальное значение вводим через консоль

Console.WriteLine("Ввод размера массива");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввод минимального значения");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввод максимального значения");
int max = int.Parse(Console.ReadLine()!);

double[] array = FillDoubleArray(size, min, max);

PrintDoubleArray(array);

double diffMaxMin = MinMax(array);
Console.WriteLine(diffMaxMin);

double[] FillDoubleArray(int length, int minValue, int maxValue)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        double number = new Random().NextDouble() * (maxValue - minValue) + minValue;
        array[i] = Math.Round(number, 2);
    }
    return array;
}

void PrintDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

double MinMax(double[] array) 
{
     double minFind = 100;
     double maxFind = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(minFind > array[i])
        {
            minFind = array[i];
        }
         if(maxFind < array[i])
        {
            maxFind = array[i];
        }
    }
        return maxFind - minFind;
}


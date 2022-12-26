// принимает на вход числа n, min, max. 
//Затем генерирует массив размером n и заполняет его случайными числами в диапазоне от min до max.
Console.WriteLine("Ввод размера массива");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввод минимального числа");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввод максимального числа");
int max = int.Parse(Console.ReadLine()!);

int[] array = new int[size];

FillArray(array);
PrintArray(array);


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
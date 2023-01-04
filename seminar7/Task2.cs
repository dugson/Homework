// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.WriteLine("Введите первый индекс элемента");
int num0 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второй индекс элемента");
int num1 = int.Parse(Console.ReadLine()!);

int[,] mainMatrix = Create2DArray(6, 8, 1, 9);
Print2DArray(mainMatrix);

int[,] Create2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

    if (num0 < matrix.GetLength(0) && num1 < matrix.GetLength(1))
    {
        Console.WriteLine("Значение элемента: " + matrix[num0, num1]);
    }
    else
    {
        Console.WriteLine("Такого элемента не существует");
    }
}

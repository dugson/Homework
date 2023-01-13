//  Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов
Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] mainMatrix = Create2DArray(4, 5, 1, 9);

Print2DArray(mainMatrix);

MinSumRow(mainMatrix);

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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MinSumRow(int[,] mainMatrix)
{
    int index = 0;
    int minsum = 0;
    for (int i = 0; i < mainMatrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < mainMatrix.GetLength(1); j++)
        {
            sum += mainMatrix[i, j];
        }
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    Console.WriteLine("строка с наименьшей суммой элементов под индексом: " + (index) + ", с суммой элементов равной: " + (minsum));
}
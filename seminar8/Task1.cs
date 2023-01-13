// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);

int[,] mainMatrix = Create2DArray(4, 4, 3, 6);

Print2DArray(mainMatrix);
SortMatrixRow(mainMatrix);

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
    Console.WriteLine();
}

void SortMatrixRow(int[,] mainMatrix)
{
    for (int i = 0; i < mainMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < mainMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < mainMatrix.GetLength(1) - 1; k++)
            {
                if (mainMatrix[i, k] < mainMatrix[i, k + 1])
                {
                    int temp = mainMatrix[i, k + 1];
                    mainMatrix[i, k + 1] = mainMatrix[i, k];
                    mainMatrix[i, k] = temp;
                }
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с отсортированными строками:");
Print2DArray(mainMatrix);

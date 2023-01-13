// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
Console.WriteLine("Введите количество строк первой матрицы");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов первой матрицы");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк второй матрицы");
int p = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов второй матрицы");
int r = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] matrixA = Create2DArray(m, n, 1, 9);
int[,] matrixB = Create2DArray(p, r, 1, 9);

Print2DArray(matrixA);
Console.WriteLine();
Print2DArray(matrixB);

int[,] matrixAxB = ProductMatrix(matrixA, matrixB);
Console.WriteLine();
Print2DArray(matrixAxB);

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

int[,] ProductMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixAxB = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixAxB[i, j] = 0;
                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixAxB[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
    }
    return matrixAxB;
}


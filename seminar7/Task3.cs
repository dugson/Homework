// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);

int[,] mainMatrix = Create2DArray(m, n, 1, 9);

Print2DArray(mainMatrix);

double[] array = ArithMeanColumn(mainMatrix);

PrintArray(array);

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

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

double[] ArithMeanColumn(int[,] mainMatrix)
{
    int columnCount = mainMatrix.GetLength(1);
    int lineCount = mainMatrix.GetLength(0);
    double[] columnArithMean = new double[columnCount];


    for (int j = 0; j < columnCount; j++)
    {
        int sumColumn = 0;
        for (int i = 0; i < lineCount; i++)
        {
            sumColumn += mainMatrix[i, j];
        }
        columnArithMean[j] = Math.Round((double)sumColumn / lineCount, 2);
    }
    return columnArithMean;
}

// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);

SumNumbers(m, n);

Console.WriteLine(SumNumbers(m, n));

int SumNumbers(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return n + SumNumbers(m, n - 1);
    }
}
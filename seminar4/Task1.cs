// цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.WriteLine("Ввод числа А");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввод числа B");
int numberB = int.Parse(Console.ReadLine()!);

int powerAB = Power(numberA, numberB);

Console.WriteLine(powerAB);

int Power(int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++)
    {
        result = result * A;
    }
    return result;
}
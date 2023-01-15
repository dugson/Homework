// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m, n 
//             n + 1,                 m = 0
// A(m, n) = { A(m - 1, 1),           m > 0, n = 0
//             A(m - 1, A(m, n - 1)), m > 0, n > 0


Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine()!);

FunctionOfAckerman(m, n);
Console.WriteLine(FunctionOfAckerman(m, n));

int FunctionOfAckerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return FunctionOfAckerman(m - 1, 1);
    }
    else
    {
        return FunctionOfAckerman(m - 1, FunctionOfAckerman(m, n - 1));
    }
}
// на вход принимает число и выдаёт, является ли число чётным
Console.WriteLine("Ввод числа");
string number = Console.ReadLine()!;
int num = int.Parse(number);

if (num % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}
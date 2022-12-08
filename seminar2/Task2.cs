// выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Отрицательные числа должны нормально работать.
Console.WriteLine("Ввод числа");
int num = int.Parse(Console.ReadLine()!);

if (num < 0)
{
    num = -num;
}
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (num > 999)
    {
        num = num / 10;
    }
    int thirdDigit = num % 10;
    Console.WriteLine("Третья цифра: " + thirdDigit);
}

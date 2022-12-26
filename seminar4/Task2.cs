// принимает на вход число и выдаёт сумму цифр в числе
Console.WriteLine("Ввод числа");
int number = int.Parse(Console.ReadLine()!);

int sumDigitFunc = SumDigitNumber(number);
Console.WriteLine(sumDigitFunc);

int SumDigitNumber(int num)
{
    int sum = 0;
    while (num >= 10)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return num + sum;
}
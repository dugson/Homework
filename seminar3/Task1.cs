//принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.WriteLine("Ввод пятизначного числа");
int number = int.Parse(Console.ReadLine()!);
number = Math.Abs(-number);

if (number > 9999 && number < 100000)
{
    int digit1 = number / 10000;
    int digit2 = number / 1000 % 10;
    int digit4 = number / 10 % 10;
    int digit5 = number % 10;

    if (digit1 == digit5 && digit2 == digit4)
    {
        Console.WriteLine("Это число - палиндром");
    }
    else
    {
        Console.WriteLine("Это число - не палиндром");
    }
}
else
{
    Console.WriteLine("Это число не пятизначное");
}





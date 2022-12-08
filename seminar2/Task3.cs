// принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Ввод номера дня недели");
int dayNumber = int.Parse(Console.ReadLine()!);

if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("Такого дня недели не существует");
}
else
{
    if (dayNumber < 6)
    {
        Console.WriteLine("Рабочий день недели");
    }
    else
    {
        Console.WriteLine("Выходной день недели");
    }
}

/*Console.WriteLine("Ввод номера дня недели");
int dayNumber = int.Parse(Console.ReadLine()!);

if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Будни");
}
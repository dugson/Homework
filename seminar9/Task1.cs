// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
// Выполнить с помощью рекурсии
Console.WriteLine("Введите число N");
int number = int.Parse(Console.ReadLine()!);
PrintNumbersFromN(number);

void PrintNumbersFromN(int number)
{
    if (number == 1)
    {
        Console.Write("1");
        return;
    }
    Console.Write(number + ", ");
    PrintNumbersFromN(number - 1);
}
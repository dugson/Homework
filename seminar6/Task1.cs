// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите количество чисел");
int countNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("Количество положительных чисел: " + CountPositiveNum(countNumber));

int CountPositiveNum(int countNumber)
{
    int counter = 0;
    for (int i = 0; i < countNumber; i++)
    {
        int number = int.Parse(Console.ReadLine()!);
        if (number > 0)
        {
            counter++;
        }
    }
    return counter;
}

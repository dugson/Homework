//на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Ввод числа");
string number = Console.ReadLine()!;
int num = int.Parse(number);
int counter = 1;

if (num > 0)
{
}
else
{
    num = -num;
}
while (counter < num)
{
    counter = counter + 1;

    if (counter % 2 == 0)
    {
        Console.Write(counter + "  ");
    }
}
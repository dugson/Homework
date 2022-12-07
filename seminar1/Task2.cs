// на вход три числа, какое больше 
Console.WriteLine("Ввод первого числа");
string number1 = Console.ReadLine()!;
int num1 = int.Parse(number1);

Console.WriteLine("Ввод второго числа");
string number2 = Console.ReadLine()!;
int num2 = int.Parse(number2);

Console.WriteLine("Ввод третьего числа");
string number3 = Console.ReadLine()!;
int num3 = int.Parse(number3);

int max = num1;

if (max < num2)
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}
Console.WriteLine(max);

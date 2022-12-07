// на вход два числа, какое больше 
Console.WriteLine("Ввод первого числа");
string number1 = Console.ReadLine()!;
int num1 = int.Parse(number1);

Console.WriteLine("Ввод второго числа");
string number2 = Console.ReadLine()!;
int num2 = int.Parse(number2);

if (num1 > num2)
{
    Console.WriteLine("Первое число больше второго");
}
if (num2 > num1)
{
    Console.WriteLine("Второе число больше первого");
}
if (num1 == num2)
{
    Console.WriteLine("Числа равны");
}
// принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine("Ввод трехзначного числа");
string number = Console.ReadLine()!;
int num = int.Parse(number);

int secdigit = num % 100 / 10;

Console.WriteLine(secdigit);

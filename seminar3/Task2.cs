//принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
Console.WriteLine("Ввод x первой точки");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввод y первой точки");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввод z первой точки");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввод x второй точки");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввод y второй точки");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввод z второй точки");
int z2 = int.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine(Math.Round(distance, 2));

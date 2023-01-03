// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2");
double k2 = double.Parse(Console.ReadLine()!);

double[] pointCross = CrossPoint(b1, k1, b2, k2);
Console.WriteLine("x = " + pointCross[0]);
Console.WriteLine("y = " + pointCross[1]);

double[] CrossPoint(double b1, double k1, double b2, double k2)
{
    double[] coordinates = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    coordinates[0] = x;
    coordinates[1] = y;
    return coordinates;
}

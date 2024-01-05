// Напишите программу которая найдет точку пересечения двух прямых
// Заданных уравнениями y=k1*x+b1, y=k2*x+b2;
// Значения b1 и k1 b2 b k2 задаются пользователем.

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"точка пересечения двух прямых ({x};{y})");
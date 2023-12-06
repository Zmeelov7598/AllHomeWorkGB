// Напишите программу, которая принемает 
// на вход координаты двух точек и находит растояние между ними в 2D пространстве.

double GetCoordinate(string name, int number)
{
    Console.Write($"Введите координату {name} для {number} точки : ");
    return Convert.ToDouble(Console.ReadLine());
}

double x1 = GetCoordinate("X", 1);
double y1 = GetCoordinate("Y", 1);
double x2 = GetCoordinate("X", 2);
double y2 = GetCoordinate("Y", 2);

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine(distance);
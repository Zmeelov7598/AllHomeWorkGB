// Напишите программу, котора принемает на вход координаты точки (X и Y), 
// причем X !=0 и Y!=0 и выдает номер четверти плоскости  в которой находитс эта точка. 

double GetNumber(string name)
{
    Console.Write($"Введите координату {name} : ");
    return Convert.ToDouble(Console.ReadLine());
}


int GetNumChetv(double x, double y)
{
    if (x > 0 && y > 0)
    return 1;
    else
    if (x < 0 && y > 0)
    return 2;
    else
    if (x < 0 && y < 0)
    return 3;
    else return 4;

}
double x = GetNumber("X");
double y = GetNumber("Y");
Console.WriteLine("номер четверти" + GetNumChetv(x,y));

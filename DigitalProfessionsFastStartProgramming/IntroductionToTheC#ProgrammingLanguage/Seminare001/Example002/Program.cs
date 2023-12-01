Console.Write("Введите первое число : ");
int firstUserNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int secondUserNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(firstUserNumber + "  " + secondUserNumber);
if (firstUserNumber / secondUserNumber == secondUserNumber)
{
    Console.WriteLine("Первое число является квадратом второго! ");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго!");
}

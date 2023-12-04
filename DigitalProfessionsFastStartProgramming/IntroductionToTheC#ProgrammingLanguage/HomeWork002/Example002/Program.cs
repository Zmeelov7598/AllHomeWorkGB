//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void FindTD(int number)
{
    while (number >= 1000)
    {
        number /= 10;
    }
    if (number < 100 && number > -100)
    {
        Console.WriteLine("Отсутствует третье число!");
    }
    else
    {
        Console.WriteLine($"Третье число : {Math.Abs(number % 10)}");
    }
}

Console.Write("Введите число : ");
FindTD(Convert.ToInt32(Console.ReadLine()));

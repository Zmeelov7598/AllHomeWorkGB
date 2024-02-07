// Написать рекурсивный метод деления одного числа 
// на другое. Нужно получить остаток от деления и 
// результат деления

int GetNumber(string name)
{
    Console.Write($"Введите {name} : ");
    return Convert.ToInt32(Console.ReadLine());
}


void GetDivision(int number1, int number2, int count)
{
    if (number1 >= number2)
    {
        number1 = number1 - number2;
        count++;
        GetDivision(number1, number2, count);
    }
    else
    {
        Console.Write($"Результат деления {count} остаток от деления = {number1}");
    }


}

GetDivision(GetNumber("числитель"), GetNumber("знаменатель"), 0);
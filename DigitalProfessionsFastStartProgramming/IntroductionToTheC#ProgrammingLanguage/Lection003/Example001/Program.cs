// Пример группы методов которые ничего не принимают и ничего не возрвщвют

void Method1()
{
    Console.WriteLine("Автор .....");
}

Method1();

// Ничего не возращают но принемают какието аргументы.

void Method2(string msq)
{
    Console.WriteLine(msq);
}

Method2("текст сообщени");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21("ТТекст Сообщения", 4);
Method21(count: 4, msg: "сообщение");

// Возращают но ничего не принемают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);


// Принемают и возращают

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "sdfsdf");
Console.WriteLine(res);

string Method41(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res2 = Method41(10, "Редиска");
Console.WriteLine(res2);

// ЦИКЛ В ЦИКЛЕ

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++) 
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
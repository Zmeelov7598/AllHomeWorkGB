string a = "Понедельник";
string b = "Вторник";
string c = "Среда";
string d = "Четверг";
string e = "Пятница";
string f = "Суббота";
string j = "Воскресенье";

Console.Write("Введите номер дня недели : ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek == 1) Console.WriteLine(a);
if (dayWeek == 2) Console.WriteLine(b);
if (dayWeek == 3) Console.WriteLine(c);
if (dayWeek == 4) Console.WriteLine(d);
if (dayWeek == 5) Console.WriteLine(e);
if (dayWeek == 6) Console.WriteLine(f);
if (dayWeek == 7) Console.WriteLine(j);
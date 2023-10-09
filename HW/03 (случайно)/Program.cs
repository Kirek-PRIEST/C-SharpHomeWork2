// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
string ReadString(string msg)
{

    Console.WriteLine(msg);
    string day = Console.ReadLine();
    string lowerDay = day.ToLower();
    return lowerDay;
}
string a = ReadString("Введите день недели:");
int b = 0;
if (a == "понедельник")
{
    b = 1;
    Console.WriteLine(b);
}
if (a == "вторник")
{
    b = 2;
    Console.WriteLine(b);
}
if (a == "среда")
{
    b = 3;
    Console.WriteLine(b);
}
if (a == "четверг")
{
    b = 4;
    Console.WriteLine(b);
}
if (a == "пятница")
{
    b = 5;
    Console.WriteLine(b);
}
if (a == "суббота")
{
    b = 6;
    Console.WriteLine(b);
}
if (a == "воскресенье")
{
    b = 7;
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int ReadInt(string msg)
{

    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int a = int.Parse(numb);
    return a;
}
int a = ReadInt("Введите порядковый номер дня недели:");

if (a > 0 & a < 8)
{
    if (a == 6 | a == 7)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else { Console.WriteLine("такого дня недели не существует"); }
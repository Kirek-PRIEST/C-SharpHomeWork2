// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int ReadInt(string msg)
{

    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int a = int.Parse(numb);
    return a;
}
int a = ReadInt("Введите трёхзначное число:");
int result = -1;
if (a >= 100)
{
    while (a > 999)
    {
        a = a / 10;
    }
    result = a % 10;
    Console.WriteLine(result);
}
else { Console.WriteLine("Третьей цифры нет"); }
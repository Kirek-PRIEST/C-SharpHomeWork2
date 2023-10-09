
// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int ReadInt(string msg) // Объявление функции и строковый параметр msg
{

    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int a = int.Parse(numb);
    return a;
}
int a = ReadInt("Введите трёхзначное число:");
if (a < 1000 & a > 99)
{
    Console.WriteLine(a % 10);
}
else {Console.WriteLine("Введено число вне диапазона");}

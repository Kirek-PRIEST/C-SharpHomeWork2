// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadInt(string msg) 
{

    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int a = int.Parse(numb);
    return a;
}
int a = ReadInt("Введите трёхзначное число:");
if (a < 1000 & a > 99)
{
    int b = a%100;
    Console.WriteLine("Второй символ в числе " + a + " - " + b / 10);
}
else 
{Console.WriteLine("Введено число вне диапазона");}
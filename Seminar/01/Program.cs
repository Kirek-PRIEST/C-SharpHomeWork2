
// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите число:");
string numb = Console.ReadLine();
int a = int.Parse(numb);

if (a<1000 & a>99)
    {
    Console.WriteLine(a%10);
    }
    Console.WriteLine("Введено число вне диапазона");

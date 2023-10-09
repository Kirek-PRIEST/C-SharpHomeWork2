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
if (a > 99)
{

}

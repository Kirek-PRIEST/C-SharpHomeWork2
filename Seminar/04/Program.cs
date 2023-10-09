// 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int ReadInt(string msg) // Объявление функции и строковый параметр msg
{

    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int a = int.Parse(numb);
    return a;
}
int numb1 = ReadInt("Введите число:");
int delSeven = numb1%7;
int delTwOne = numb1%21;

if (delSeven == 0 & delTwOne == 0)
{
Console.WriteLine("Число " + numb1 + " делится на 7 и 21");
}
else
{
Console.WriteLine("Число " + numb1 + " не делится на 7 и 21");
}
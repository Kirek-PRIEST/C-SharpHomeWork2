// Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу
// 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int ReadInt(string msg) // Объявление функции и строковый параметр msg
{

    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int a = int.Parse(numb);
    return a;
}
int numb1 = ReadInt("Введите первое число:");
int numb2 = ReadInt("Введите второе число:");
int result = numb1 % numb2;
if (result == 0)
{
    Console.WriteLine("Число 1 делится без остатка на число 2");
}
else
{
    Console.WriteLine("Число не делится без остатка на число 2. Остаток: " + result);
}
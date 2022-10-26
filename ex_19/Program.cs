// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string Check(int x)
{
    if ((x / 10000) == (x % 10) && ((x / 1000) % 10) == ((x / 10) % 10))
    {
        return "да";
    }
    else
    {
        return "нет";
    }
}

Console.Clear();
int X = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{Check(X)}");
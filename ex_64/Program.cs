// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

string Rec(int n)
{
    if (n <= 1) return "1";
    else return $"{n}, {Rec(n - 1)}";
}
Console.Clear();
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Rec(N));
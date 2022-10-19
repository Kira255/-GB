// Задача 10. Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

int num = int.Parse(Console.ReadLine()!);
num = (num / 10) % 10;
Console.WriteLine(num);
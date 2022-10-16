// Задача 6. Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();

int num = int.Parse(Console.ReadLine()!);

if (num % 2 == 1 || num % 2 == -1)
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("да");
}
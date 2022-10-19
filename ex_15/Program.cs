// Задача 15. Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

int num = int.Parse(Console.ReadLine()!);
if (num >= 6)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
// Задача 13. Программа, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

int num = int.Parse(Console.ReadLine()!);
if (num >= 100)
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    num = num % 10;
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
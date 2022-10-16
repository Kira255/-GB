// Задача 2: Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    Console.WriteLine($"max = {num1}");
}
else
{
    Console.WriteLine($"max = {num2}");
}
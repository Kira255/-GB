// Задача 4. Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int num3 = int.Parse(Console.ReadLine()!);

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"max = {num1}");
}
if (num2 > num1 && num2 > num3)
{
    Console.WriteLine($"max = {num2}");
}
else
{
    Console.WriteLine($"max = {num3}");
}
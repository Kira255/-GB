// Задача 8. Программа, которая на вход принимает число(N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

int num = int.Parse(Console.ReadLine()!);
int index = 2;

while (index <= num)
{
    Console.WriteLine(index);
    index = index + 2;
}
// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

void Ob(int p, int z)
{
    for (int i = 0; i < p; i++)
    {
        Console.Write(" ");
    }
    for (int i = 0; i < z; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.Clear();

Console.Write("Высота елочки: ");
int n = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= n; i++)
    Ob(n - i, i * 2 - 1);
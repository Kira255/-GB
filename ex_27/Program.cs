// Задача 27. Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

int Get(int a)
{
    int sum = 0;
    int i = 0;
    int b = a;
    int c = a;
    while (a > 0)
    {
        a = a / 10;
        i++;
    }
    while (i > 0)
    {
        b = c % 10;
        c = c / 10;
        sum = sum + b;
        i--;
    }
    return sum;
}

Console.Clear();

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{Get(A)}");
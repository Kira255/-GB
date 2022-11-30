// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Rec(int m, int n, int sum)
{
    sum = sum + n;
    if (n == m)
    {
        return sum;
    }
    return Rec(m, n - 1, sum);
}
Console.Clear();
int sum = 0;
Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Rec(M, N, sum));
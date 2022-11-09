// Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Get(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res = res * a;
    }
    return res;
}

Console.Clear();

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральную степень B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{Get(A, B)}");
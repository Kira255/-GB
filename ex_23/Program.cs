// Задача 23. Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

string Get(int x)
{
    string result = "";
    for (int i = 1; i < x; i++)
    {
        result += (i * i * i).ToString() + ", ";
    }
    result += (x * x * x).ToString();
    return result;
}
Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{Get(N)}");
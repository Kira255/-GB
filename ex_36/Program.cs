// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] Get(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-100, 100);
    }
    Console.WriteLine($"[{string.Join(", ", res)}]");
    return res;
}

int Num(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        sum = sum + (array[i]);
        i++;
    }
    return sum;
}

Console.Clear();

int[] array = Get(5);
Console.WriteLine(Num(array));

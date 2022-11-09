// Задача 29. Программа, которая задаёт массив из 8 элементов и выводит их на экран.

int[] FillArray()
{
    int[] a = new int[8];
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write("Введите число: ");
        a[i] = int.Parse(Console.ReadLine()!);
    }
    return a;
}

Console.Clear();

int[] array = FillArray();
Console.Write(String.Join(", ", array));


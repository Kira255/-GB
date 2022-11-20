// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Get(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!); ;
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum++;
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите количество элементов в массиве: ");
int count = int.Parse(Console.ReadLine()!);
int[] newarray = new int[count];
Get(newarray);
Console.WriteLine($"Количество положительных чисел: {Sum(newarray)}");

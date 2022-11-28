// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int Revers(int[,] array, int rows)
{
    int counter = array[rows, 0];
    for (int i = 1; i < array.GetLength(1); i++)
    {
        counter += array[rows, i];
    }
    return counter;
}

int Min(int[,] array)
{
    int row = 0;
    int el = Revers(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (el > Revers(array, i))
        {
            row = i;
            el = Revers(array, i);
        }
    }
    return row;
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во стобцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 100);
PrintArray(array);
Console.WriteLine();
int r = Min(array);
Console.WriteLine($"Строка с минимальной суммой элементов: {r}");
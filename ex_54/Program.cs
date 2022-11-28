// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void Revers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        bool Sort;
        int cell;
        do
        {
            Sort = true;
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[i, j] > array[i, j - 1])
                {
                    cell = array[i, j];
                    array[i, j] = array[i, j - 1];
                    array[i, j - 1] = cell;
                    Sort = false;
                }
            }
        } while (!Sort);
    }
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во стобцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 100);
PrintArray(array);
Revers(array);
Console.WriteLine();
PrintArray(array);
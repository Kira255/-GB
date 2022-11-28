// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] mul(int[,] a1, int[,] a2)
{
    int rows1 = a1.GetLength(0);
    int cols1 = a1.GetLength(1);
    int rows2 = a2.GetLength(0);
    int cols2 = a2.GetLength(1);
    int rows3 = rows1;
    int cols3 = (cols1 > cols2) ? cols2 : cols1;

    int[,] a3 = new int[rows3, cols3];
    for (int i = 0; i < rows3; i++)
    {
        for (int j = 0; j < cols3; j++)
        {
            a3[i, j] = 0;
            for (int t = 0; t < rows2; t++)
            {
                a3[i, j] += (a1[i, t] * a2[t, j]);
            }
        }
    }
    return a3;
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во стобцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array1 = GetArray(rows, cols, 1, 10);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = GetArray(rows, cols, 1, 10);
PrintArray(array2);
Console.WriteLine();
int[,] array3 = mul(array1, array2);
PrintArray(array3);
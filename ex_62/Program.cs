// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4;
int[,] Matrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
    Matrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= Matrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > Matrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(Matrix);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

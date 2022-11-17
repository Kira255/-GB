// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] Get(int size, int l, int r)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round(new Random().NextDouble() * (r - l) + l, 3);
    }
    return res;
}

double MaxEl(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinEl(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

Console.WriteLine("Введите размер массива: ");
int s = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение слева: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение справа: ");
int b = int.Parse(Console.ReadLine()!);
double[] array = Get(s, a, b);
Console.WriteLine($"[{string.Join(", ", array)}]");
double sum = MaxEl(array) - MinEl(array);
Console.WriteLine($"Разница {sum}");

// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
int[] Get(int[] array)
{
    string[] mass = { "b1", "k1", "b2", "k2" };
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!); ;
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
    return array;
}

void Intersection(int[] array)
{
    int b1 = array[0];
    int k1 = array[1];
    int b2 = array[2];
    int k2 = array[3];
    double x, y;
    double z1 = b1 - b2;
    double z2 = k2 - k1;
    if (b1 == b2 && k1 == k2) Console.WriteLine("Прямые совпадают");
    else if (k1 == k2) Console.WriteLine("Прямые параллельны");
    else
    {
        x = z1 / z2;
        Console.WriteLine(x);
        y = k2 * x + b2;
        Console.WriteLine("Точка пересечения" + "(" + x + ";" + y + ")");
    }
}
Console.Clear();
int[] newarray = new int[4];
Get(newarray);
Intersection(newarray);


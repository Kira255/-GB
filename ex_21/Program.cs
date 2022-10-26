// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

static double Get(int x0, int y0, int z0, int x1, int y1, int z1)
{
    double result = Math.Round(Math.Sqrt(Math.Pow(y1 - y0, 2) + Math.Pow(x1 - x0, 2) + Math.Pow(z1 - z0, 2)), 2);
    return result;
}
Console.Clear();
Console.Write("Введите координату x1: ");
int X0 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y1: ");
int Y0 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z1: ");
int Z0 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату x2: ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y2: ");
int Y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z2: ");
int Z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{Get(X0, Y0, Z0, X1, Y1, Z1)}");

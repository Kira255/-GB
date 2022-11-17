// 

int[] Get(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine($"[{string.Join(", ", res)}]");
    return res;
}

int Num(int[] array)
{
    int c = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            c++;
        }
    }
    return c;
}

int[] array = Get(12);
Console.WriteLine(Num(array));
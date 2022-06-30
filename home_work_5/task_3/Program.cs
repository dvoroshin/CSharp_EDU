// ищет разницу между максимальным и минимальным вещественными элементами массива 

double[] GetArray(int size)
{
    Random rand = new Random();
    if (size <= 0)
        size = 1;
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.NextDouble() * 100;
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write($"{Environment.NewLine}Исходный массив: [");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i],0:F2}, ");
    }
    Console.Write($"{array[array.Length - 1],0:F2}]{Environment.NewLine}");
}

void DifMinMax(double[] array)
{
    double min = double.MaxValue;
    double max = double.MinValue;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    Console.WriteLine($"Разница между максимальным и мнимальным элементами массива: {max - min,0:F2}");
}

double[] AskUser()
{
    Console.Clear();
    Console.Write($"{Environment.NewLine}Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = GetArray(size);
    PrintArray(array);

    return array;
}

DifMinMax(AskUser());
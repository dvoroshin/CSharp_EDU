// считает сумму нечетных элементов в массиве

int[] GetArray(int size)
{
    Random rand = new Random();
    if (size <= 0)
        size = 1;
    int[] array = new int[size];
    Console.Write("Введете минимальный предел рандомизации: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введете максимальный предел рандомизации: ");
    int max = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"{Environment.NewLine}Исходный массив: [");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]{Environment.NewLine}");
}

void SumOddNum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) sum += array[i];
    }

    Console.WriteLine($"Сумма нечетных элементов в массиве: {sum}");
}

int[] AskUser()
{
    Console.Write($"{Environment.NewLine}Введите размерность массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = GetArray(size);
    PrintArray(array);

    return array;
}

SumOddNum(AskUser());
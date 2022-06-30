// определяет количество элементов в диапазоне 

int[] GetArray(int size)
{
    Random rand = new Random();
    int[] array = new int[size];
    Console.Write($"{Environment.NewLine}Введите минимальный предел рандомизации: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите максимальный предел рандомизации: ");
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

void CountNumInSegment(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) count++;
    }

    Console.WriteLine($"{Environment.NewLine}Количество элементов массива в диапазоне от 10 до 99: {count}");
}

int[] AskUser()
{
    Console.Clear();
    Console.Write($"По условию задачи размер массива равен 123.{Environment.NewLine}");
    int[] array = GetArray(123);
    PrintArray(array);

    return array;
}

CountNumInSegment(AskUser());
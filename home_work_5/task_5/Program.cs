// ищет произведение пар чисел и выводит в новый массив 

int[] GetArray(int size)
{
    Random rand = new Random();
    if (size <= 0)
        size = 1;
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
    Console.Write($"[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]{Environment.NewLine}");
}

void MulPairNum(int[] array)
{
    int sizeR = 0;
    if (array.Length % 2 == 0) sizeR = array.Length / 2;
    else sizeR = array.Length / 2 + 1;

    int[] arrayR = new int[sizeR];

    for (int i = 0; i < array.Length / 2; i++)
    {
        arrayR[i] = array[i]*array[array.Length-1-i];
    }

    if(array.Length % 2 != 0) arrayR[sizeR-1] = array[(array.Length-1)/2];

    Console.Write($"{Environment.NewLine}Результирующий массив: ");
    PrintArray(arrayR);
}

int[] AskUser()
{
    Console.Clear();
    Console.Write($"{Environment.NewLine}Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = GetArray(size);
    Console.Write($"{Environment.NewLine}Исходный массив: ");
    PrintArray(array);

    return array;
}

MulPairNum(AskUser());

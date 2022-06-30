// показывает количество четных чисел в массиве

int[] GetArray(int size)
{
    Random rand = new Random();
    if (size <= 0)
        size = 1;
    int[] array = new int[size];
    //Console.Write("Введете минимальный предел рандомизации: ");
    int min = 100;
    //Convert.ToInt32(Console.ReadLine());
    //Console.Write("Введете максимальный предел рандомизации: ");
    int max = 999;
    //Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.Write("Исходный массив: [");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}

void CountEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }

    Console.Write($"Количество четных элементов в массиве: {count}");
}

int[] AskUser()
{
    Console.Write("Введите размерность массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = GetArray(size);
    PrintArray(array);

    return array;
}

CountEvenNum(AskUser());
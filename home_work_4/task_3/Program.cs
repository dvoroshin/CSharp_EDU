// программа создает массив из 8 (N) элементов и выводит их на экран

Console.Clear();

int[] askUser()
{
    int size = 8; // по условию так, но ниже общий случай
    Console.Write("Введете размер массива: ");
    size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введете массив сами или заполнить рандомно? Если сами, то введите букву Y, если рандомно то любой другой символ: ");
    string? ask = Console.ReadLine();
    if (ask == "Y" || ask == "y")
    {
        Console.WriteLine("Введите последовательно элементы массива: ");
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        return array;
    }
    else
    {
        Random rand = new Random();
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
}

void printArray(int[] array)
{
    Console.Write("Массив: [" + array[0] + ", ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
}

int[] array = askUser();

printArray(array);
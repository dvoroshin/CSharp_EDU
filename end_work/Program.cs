// создает новый массив из введеного, где каждый строковый элемент не больше трех символов

string[] FillArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void PrintArray(string[] array, string text)
{
    Console.WriteLine($"{Environment.NewLine}{text}:");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"\"{array[i]}\"{Environment.NewLine}");
        }
        else
        {
            Console.Write($"\"{array[i]}\",");
        }
    }
}

string[] ChoosArray(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }

    string[] Str3Char = new string[count];

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Str3Char[j] = array[i];
            j++;
        }
    }
    return Str3Char;
}

Console.Clear();

Console.Write($"{Environment.NewLine}Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{Environment.NewLine}Введите последовательно элементы массива: ");
string[] array = FillArray(size);

PrintArray(array, "Исходный массив");

PrintArray(ChoosArray(array), "Результат");
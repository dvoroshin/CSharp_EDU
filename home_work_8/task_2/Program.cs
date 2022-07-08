// находит строку с наименьшей суммой элементов

int[,] CreateRandomArrayTwo(int m, int n, int min, int max)
{
    int[,] arrayTwo = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arrayTwo[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arrayTwo;
}

void ShowArrayTwo(int[,] arrayTwo, string nameArray)
{
    Console.WriteLine($"{Environment.NewLine}{nameArray} массив:");
    for (int i = 0; i < arrayTwo.GetLength(0); i++)
    {
        Console.Write($"[{i}] ");
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            Console.Write($"{arrayTwo[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MinSumOfRowsInArray(int[,] arrayTwo)
{
    int min = int.MaxValue, minIndex = int.MaxValue;

    int[] arrayOne = new int[arrayTwo.GetLength(0)];

    for (int i = 0; i < arrayTwo.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            arrayOne[i] += arrayTwo[i, j];
        }
    }

    Console.WriteLine($"{Environment.NewLine}Сумма элементов по строкам:");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        Console.Write($"{arrayOne[i]}\t");
    }
    Console.WriteLine();

    for (int i = 0; i < arrayOne.Length; i++)
    {
        if (arrayOne[i] < min)
        {
            min = arrayOne[i];
            minIndex = i;
        }
    }
    return minIndex;
}

Console.Clear();

Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter min number for random: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter max number for random: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] arrayTwo = CreateRandomArrayTwo(rows, columns, min, max);

ShowArrayTwo(arrayTwo, "Исходный");

Console.WriteLine($"Строка с наименьшей суммой элементов имеет индекс: {MinSumOfRowsInArray(arrayTwo)}");
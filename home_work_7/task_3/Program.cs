// выводит среднее арифметическое каждого из столбцов двумерного массива

int[,] CreateRandomArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void ShowArrayOne(double[] array)
{
    Console.WriteLine("Среднее арифметическое по столбцам:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i],0:F1}\t");
    }
    Console.WriteLine();
}

void ShowArrayTwo(int[,] array)
{
    Console.WriteLine($"{Environment.NewLine}Исходный массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [] GetAmeanColumns(int [,] arrayTwo)
{
    double[] arrayMean = new double[arrayTwo.GetLength(1)];

    for (int i = 0; i < arrayTwo.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            arrayMean[i] += arrayTwo[j,i];
        }
        arrayMean[i] /= arrayTwo.GetLength(0);
    }
    return arrayMean;
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

int[,] array = CreateRandomArray(rows, columns, min, max);

ShowArrayTwo(array);
ShowArrayOne(GetAmeanColumns(array));
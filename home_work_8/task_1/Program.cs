// упорядочит по убыванию элементы каждой строки двумерного массива

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

void ShowArrayTwo(int[,] array, string nameArray)
{
    Console.WriteLine($"{Environment.NewLine}{nameArray} массив:");
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

void SortArray(int[,] array)
{
    int buf = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i,j] < array[i,k])
                {
                    buf = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = buf;
                }
            }
        }
    }
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

ShowArrayTwo(array, "Исходный");
SortArray(array);
ShowArrayTwo(array, "Результирующий");
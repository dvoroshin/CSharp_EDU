// создает двумерный массив рандомных вещественных чисел с размером MxN 

double[,] CreateRandomArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
        }
    }
    return array;
}

void ShowArray(double[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 0:F2}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();

Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateRandomArray(rows, columns));
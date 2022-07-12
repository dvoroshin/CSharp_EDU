// перемножает две матрицы 

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
    Console.WriteLine($"{Environment.NewLine}{nameArray}");
    for (int i = 0; i < arrayTwo.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            Console.Write($"{arrayTwo[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MultiplicateMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Введенные матрицы перемножить невозможно!");
    }
    else
    {
        int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    matrixResult[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        ShowArrayTwo(matrixResult, "Результат: ");
    }
}

Console.Clear();

Console.Write("Enter number of rows for matrix #1: ");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of columns for matrix #1: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of rows for matrix #2: ");
int rows2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of columns for matrix #2: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter min number for random: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter max number for random: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = CreateRandomArrayTwo(rows1, columns1, min, max);
int[,] matrix2 = CreateRandomArrayTwo(rows2, columns2, min, max);

ShowArrayTwo(matrix1, "Исходная матрица 1:");
ShowArrayTwo(matrix2, "Исходная матрица 2:");
MultiplicateMatrix(matrix1, matrix2);
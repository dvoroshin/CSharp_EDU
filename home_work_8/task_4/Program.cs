// создает трехмерный массив из неповторяющихся двузначных чисел

int[,,] CreateRandomArrayThree(int x, int y, int z)
{
    int[,,] arrayThree = new int[x, y, z];
    int[] arrayForRepeat = new int[x * y * z];
    int min = 10, max = 99; //т.к двузначные числа

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                arrayThree[i, j, k] = min;
                min++;
                if(min == max)
                {
                    min *= -1;
                    max = -10;
                }
            }
        }
    }
    return arrayThree;
}

void ShowArrayThree(int[,,] arrayThree, string nameArray)
{
    Console.WriteLine($"{Environment.NewLine}{nameArray}");
    for (int i = 0; i < arrayThree.GetLength(0); i++)
    {
        for (int j = 0; j < arrayThree.GetLength(1); j++)
        {
            for (int k = 0; k < arrayThree.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}]{arrayThree[i, j, k]}\t");
            }
            Console.WriteLine();
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

Console.Write("Enter number of bar: ");
int bar = Convert.ToInt32(Console.ReadLine());

int[,,] array = CreateRandomArrayThree(rows, columns, bar);

ShowArrayThree(array, "Трехмерный массив:");